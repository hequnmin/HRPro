using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
//using System.ServiceModel;

namespace HR.Core.Util
{
    /// <summary>
    /// 异常处理类
    /// </summary>
    public class CryptoHelpException : ApplicationException
    {
        public CryptoHelpException(string msg) : base(msg) { }
    }

    /// <summary>
    /// CryptHelp
    /// </summary>
    public class CryptoHelper
    {
        private const ulong FC_TAG = 0xFC010203040506CF;

        private const int BUFFER_SIZE = 128 * 1024;

        /// <summary>
        /// 检验两个Byte数组是否相同
        /// </summary>
        /// <param name="b1">Byte数组</param>
        /// <param name="b2">Byte数组</param>
        /// <returns>true－相等</returns>
        private static bool CheckByteArrays(byte[] b1, byte[] b2)
        {
            if (b1.Length == b2.Length)
            {
                for (int i = 0; i < b1.Length; ++i)
                {
                    if (b1[i] != b2[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// 创建DebugLZQ ,http://www.cnblogs.com/DebugLZQ
        /// </summary>
        /// <param name="password">密码</param>
        /// <param name="salt"></param>
        /// <returns>加密对象</returns>
        private static SymmetricAlgorithm CreateRijndael(string password, byte[] salt)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, salt, "SHA256", 1000);

            SymmetricAlgorithm sma = Rijndael.Create();
            sma.KeySize = 256;
            sma.Key = pdb.GetBytes(32);
            sma.Padding = PaddingMode.PKCS7;
            return sma;
        }

        /// <summary>
        /// 加密文件随机数生成
        /// </summary>
        private static RandomNumberGenerator rand = new RNGCryptoServiceProvider();

        /// <summary>
        /// 生成指定长度的随机Byte数组
        /// </summary>
        /// <param name="count">Byte数组长度</param>
        /// <returns>随机Byte数组</returns>
        private static byte[] GenerateRandomBytes(int count)
        {
            byte[] bytes = new byte[count];
            rand.GetBytes(bytes);
            return bytes;
        }

        /// <summary>
        /// 加密文件
        /// </summary>
        /// <param name="inFile">待加密文件</param>
        /// <param name="outFile">加密后输入文件</param>
        /// <param name="password">加密密码</param>
        public static void EncryptFile(string inFile, string outFile, string password)
        {
            using (FileStream fin = File.OpenRead(inFile),
                fout = File.OpenWrite(outFile))
            {
                long lSize = fin.Length; // 输入文件长度
                int size = (int)lSize;
                byte[] bytes = new byte[BUFFER_SIZE]; // 缓存
                int read = -1; // 输入文件读取数量
                int value = 0;

                // 获取IV和salt
                byte[] IV = GenerateRandomBytes(16);
                byte[] salt = GenerateRandomBytes(16);

                // 创建加密对象
                SymmetricAlgorithm sma = CryptoHelper.CreateRijndael(password, salt);
                sma.IV = IV;

                // 在输出文件开始部分写入IV和salt
                fout.Write(IV, 0, IV.Length);
                fout.Write(salt, 0, salt.Length);

                // 创建散列加密
                HashAlgorithm hasher = SHA256.Create();
                using (CryptoStream cout = new CryptoStream(fout, sma.CreateEncryptor(), CryptoStreamMode.Write),
                    chash = new CryptoStream(Stream.Null, hasher, CryptoStreamMode.Write))
                {
                    BinaryWriter bw = new BinaryWriter(cout);
                    bw.Write(lSize);

                    bw.Write(FC_TAG);

                    // 读写字节块到加密流缓冲区
                    while ((read = fin.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        cout.Write(bytes, 0, read);
                        chash.Write(bytes, 0, read);
                        value += read;
                    }
                    // 关闭加密流
                    chash.Flush();
                    chash.Close();

                    // 读取散列
                    byte[] hash = hasher.Hash;

                    // 输入文件写入散列
                    cout.Write(hash, 0, hash.Length);

                    // 关闭文件流
                    cout.Flush();
                    cout.Close();
                }
            }
        }

        /// <summary>
        /// 解密文件
        /// </summary>
        /// <param name="inFile">待解密文件</param>
        /// <param name="outFile">解密后输出文件</param>
        /// <param name="password">解密密码</param>
        public static void DecryptFile(string inFile, string outFile, string password)
        {
            // 创建打开文件流
            using (FileStream fin = File.OpenRead(inFile),
                fout = File.OpenWrite(outFile))
            {
                int size = (int)fin.Length;
                byte[] bytes = new byte[BUFFER_SIZE];
                int read = -1;
                int value = 0;
                int outValue = 0;

                byte[] IV = new byte[16];
                fin.Read(IV, 0, 16);
                byte[] salt = new byte[16];
                fin.Read(salt, 0, 16);

                SymmetricAlgorithm sma = CryptoHelper.CreateRijndael(password, salt);
                sma.IV = IV;

                value = 32;
                long lSize = -1;

                // 创建散列对象, 校验文件
                HashAlgorithm hasher = SHA256.Create();

                using (CryptoStream cin = new CryptoStream(fin, sma.CreateDecryptor(), CryptoStreamMode.Read),
                    chash = new CryptoStream(Stream.Null, hasher, CryptoStreamMode.Write))
                {
                    // 读取文件长度
                    BinaryReader br = new BinaryReader(cin);
                    lSize = br.ReadInt64();
                    ulong tag = br.ReadUInt64();

                    if (FC_TAG != tag)
                        throw new CryptoHelpException("文件被破坏");

                    long numReads = lSize / BUFFER_SIZE;

                    long slack = (long)lSize % BUFFER_SIZE;

                    for (int i = 0; i < numReads; ++i)
                    {
                        read = cin.Read(bytes, 0, bytes.Length);
                        fout.Write(bytes, 0, read);
                        chash.Write(bytes, 0, read);
                        value += read;
                        outValue += read;
                    }

                    if (slack > 0)
                    {
                        read = cin.Read(bytes, 0, (int)slack);
                        fout.Write(bytes, 0, read);
                        chash.Write(bytes, 0, read);
                        value += read;
                        outValue += read;
                    }

                    chash.Flush();
                    chash.Close();

                    fout.Flush();
                    fout.Close();

                    byte[] curHash = hasher.Hash;

                    // 获取比较和旧的散列对象
                    byte[] oldHash = new byte[hasher.HashSize / 8];
                    read = cin.Read(oldHash, 0, oldHash.Length);
                    if ((oldHash.Length != read) || (!CheckByteArrays(oldHash, curHash)))
                        throw new CryptoHelpException("文件被破坏");
                }

                if (outValue != lSize)
                    throw new CryptoHelpException("文件大小不匹配");
            }
        }

        #region MD5加密
        /// <summary>  
        /// MD5加密  
        /// </summary>  
        /// <param name="strSource">需要加密的字符串</param>  
        /// <returns>MD5加密后的字符串</returns>  
        //[OperationContract]
        public static string Md5Encrypt(string strSource)
        {
            //把字符串放到byte数组中  
            byte[] bytIn = System.Text.Encoding.Default.GetBytes(strSource);
            //建立加密对象的密钥和偏移量          
            byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量  
            byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥  
            //实例DES加密类  
            DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
            mobjCryptoService.Key = iv;
            mobjCryptoService.IV = key;
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            //实例MemoryStream流加密密文件  
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();

            string strOut = System.Convert.ToBase64String(ms.ToArray());
            return strOut;
        }
        #endregion

        #region MD5解密
        /// <summary>  
        /// MD5解密  
        /// </summary>  
        /// <param name="Source">需要解密的字符串</param>  
        /// <returns>MD5解密后的字符串</returns>  
        //[OperationContract]
        public static string Md5Decrypt(string Source)
        {
            if (string.IsNullOrWhiteSpace(Source)) return "";

            try
            {
                //将解密字符串转换成字节数组  
                byte[] bytIn = System.Convert.FromBase64String(Source);
                //给出解密的密钥和偏移量，密钥和偏移量必须与加密时的密钥和偏移量相同  
                byte[] iv = { 102, 16, 93, 156, 78, 4, 218, 32 };//定义偏移量  
                byte[] key = { 55, 103, 246, 79, 36, 99, 167, 3 };//定义密钥  
                DESCryptoServiceProvider mobjCryptoService = new DESCryptoServiceProvider();
                mobjCryptoService.Key = iv;
                mobjCryptoService.IV = key;
                //实例流进行解密  
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);
                ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
                StreamReader strd = new StreamReader(cs, Encoding.Default);
                return strd.ReadToEnd();
            }
            catch(Exception ex)
            {
                LogHelper.WriteError(ex);
                //throw new Exception("解密错误，密码已被破坏！");
                return string.Empty;    //解密错误返回空字符串
            }
        }
        #endregion
    }
}