using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Net.NetworkInformation;
//using System.Windows.Forms;
using System.Text.RegularExpressions;

using HR.Core.Entity;
using Newtonsoft.Json;

namespace HR.Core.Util
{
    public static class Comm
    {
        //public enum CRUD { Create, Retrieve, Update, Delete }

        //弃用，Hex2Byte代替Hexstring2Byte
        //public static byte[] Hexstring2Byte(string hexString, string strSeparator)
        //{
        //    string[] bytStrings;
        //    bytStrings = hexString.Split(strSeparator.ToCharArray());
        //    byte[] bytOut;
        //    if (string.IsNullOrWhiteSpace(hexString))
        //    {
        //        bytOut = new byte[0];
        //        return bytOut;
        //    }
        //    bytOut = new byte[bytStrings.Length];
        //    for (int i = 0; i <= bytStrings.Length - 1; i++)
        //    {
        //        // bytOut[i] = Byte.Parse(bytStrings[i], System.Globalization.NumberStyles.HexNumber);
        //        byte tryParse = 0;
        //        if (Byte.TryParse(bytStrings[i], System.Globalization.NumberStyles.HexNumber, null, out tryParse))
        //        {
        //            bytOut[i] = tryParse;
        //        }
        //    }
        //    return bytOut;
        //}

        //弃用，Byte2Hex代替Byte2HexString
        //public static string Byte2HexString(byte[] bytBuf, string strSeparator)
        //{
        //    string strLine = "";
        //    string strSingle;
        //    if (bytBuf != null)
        //    {
        //        for (int i = 0; i < bytBuf.Length; i++)
        //        {
        //            strSingle = string.Format("{0:X}", bytBuf[i]);
        //            if (strSingle.Length == 1) strSingle = "0" + strSingle;
        //            if (strLine.Length <= 0)
        //            {
        //                strLine = strSingle;
        //            }
        //            else
        //            {
        //                strLine = strLine + strSeparator + strSingle;
        //            }
        //        }
        //    }
        //    return strLine;
        //}

        //public static byte[] Hex2Byte(string hex, string separator)
        public static byte[] Hex2Byte(this string hex, string separator)
        {
            byte[] byt;

            if (string.IsNullOrWhiteSpace(hex))
            {
                byt = new byte[0];
                return byt;
            }

            if (string.IsNullOrEmpty(separator))
            {
                string strValue = hex;
                if (strValue.Length % 2 == 1) strValue = "0" + strValue;
                byt = new byte[strValue.Length / 2];
                for (int i = 0; i < byt.Length; i++)
                {
                    string str = strValue.Substring(i * 2, 2);
                    if (Byte.TryParse(str, System.Globalization.NumberStyles.HexNumber, null, out byte tryParse))
                    {
                        byt[i] = tryParse;
                    }
                }
            }
            else
            {
                string[] str;

                str = hex.Split(separator.ToCharArray());
                byt = new byte[str.Length];

                for (int i = 0; i <= str.Length - 1; i++)
                {
                    if (Byte.TryParse(str[i], System.Globalization.NumberStyles.HexNumber, null, out byte tryParse))
                    {
                        byt[i] = tryParse;
                    }
                }
            }

            return byt;
        }

        //public static string Byte2Hex(byte[] buf, string separator)
        public static string Byte2Hex(this byte[] buf, string separator)
        {
            if (buf == null)
            {
                return string.Empty;
            }
            else
            {
                //return Encoding.Default.GetString(buf).Replace("-", separator);
                return BitConverter.ToString(buf).Replace("-", separator);
            }
        }

        //public static string Byte2Ascii(byte[] buf)
        public static string Byte2Ascii(this byte[] buf)
        {
            if (buf == null)
            {
                return string.Empty;
            }
            else
            {
                return Encoding.ASCII.GetString(buf);
            }
        }

        public static string Byte2Char(this byte[] buf)
        {
            if (buf == null)
            {
                return string.Empty;
            }
            else
            {
                return Regex.Replace(Encoding.ASCII.GetString(buf), @"[^\u0020-\u007E]", "");
            }
        }

        public static byte[] Dec2Byte(this string dec, string separator)
        {
            byte[] byt;

            if (string.IsNullOrWhiteSpace(dec))
            {
                byt = new byte[0];
                return byt;
            }

            if (string.IsNullOrEmpty(separator))
            {
                string strValue = dec;
                if (strValue.Length % 2 == 1) strValue = "0" + strValue;
                byt = new byte[strValue.Length / 2];
                for (int i = 0; i < byt.Length; i++)
                {
                    string str = strValue.Substring(i * 2, 2);
                    if (Byte.TryParse(str, System.Globalization.NumberStyles.Integer, null, out byte tryParse))
                    {
                        byt[i] = tryParse;
                    }
                }
            }
            else
            {
                string[] str;

                str = dec.Split(separator.ToCharArray());
                byt = new byte[str.Length];

                for (int i = 0; i <= str.Length - 1; i++)
                {
                    if (Byte.TryParse(str[i], System.Globalization.NumberStyles.Integer, null, out byte tryParse))
                    {
                        byt[i] = tryParse;
                    }
                }
            }

            return byt;
        }
        /*
        /// <summary>
        /// C# Hashtable转object实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T Hashtable2Object<T>(Hashtable source)
        {
            T obj = Activator.CreateInstance<T>();
            object tv;

            PropertyInfo[] ps = obj.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (PropertyInfo p in ps)
            {
                if (source.ContainsKey(p.Name))
                {
                    tv = source[p.Name];

                    if (p.PropertyType.IsArray)//数组类型,单独处理
                    {
                        //p.SetValue(obj, tv, null);
                        if (p.PropertyType == typeof(byte[]))
                        {
                            //p.SetValue(obj, Convert.FromBase64String(tv.ToString()), null);
                            try
                            {
                                p.SetValue(obj, Convert.FromBase64String(tv.ToString()), null);
                            }
                            catch
                            {
                                //兼容旧版本的测试文件中存在List<byte>的属性
                                //如:CmdCustom.Data，测试文件中旧版本采用List<byte>，现版本采用byte[]，故需再做兼容性转换
                                List<byte> by = Util.JsonHelper.DeserializeJsonToList<byte>(tv.ToString());
                                if (by.Count > 0) p.SetValue(obj, by.ToArray(), null);
                            }
                        }
                        else
                        {
                            p.SetValue(obj, tv, null);
                        }
                    }
                    else if (p.PropertyType.IsGenericType)
                    {
                        //if (p.Name == "CommandIOs")
                        //{
                        //    List<Entity.CommandIO> ios = Util.JsonHelper.DeserializeJsonToList<Entity.CommandIO>(tv.ToString());
                        //    if (ios.Count > 0)      //读入文件有参数才读取，无参数默认定义值
                        //    {
                        //        p.SetValue(obj, ios, null);
                        //    }
                        //}
                        string json = tv.ToString();
                        if (!string.IsNullOrWhiteSpace(json))
                        {

                            switch (p.PropertyType.GenericTypeArguments[0].Name)
                            {
                                case "CommandIO":
                                    //List<Entity.CommandIO> io = Util.JsonHelper.DeserializeJsonToList<Entity.CommandIO>(json);
                                    ObservableCollection<Entity.CommandIO> io = Util.JsonHelper.DeserializeJsonToCollection<Entity.CommandIO>(json);
                                    if (io.Count > 0) p.SetValue(obj, io, null);
                                    break;
                                case "ChannelBase":
                                    List<Entity.ChannelBase> ch = Util.JsonHelper.DeserializeJsonToList<Entity.ChannelBase>(json);
                                    if (ch.Count > 0) p.SetValue(obj, ch, null);
                                    break;
                                case "Byte":
                                    List<byte> by = Util.JsonHelper.DeserializeJsonToList<byte>(json);
                                    if (by.Count > 0) p.SetValue(obj, by, null);
                                    break;
                                case "String":
                                    List<string> st = Util.JsonHelper.DeserializeJsonToList<string>(json);
                                    if (st.Count > 0) p.SetValue(obj, st, null);
                                    break;
                                case "SendDataImport":
                                    List<Entity.SendDataImport> sdi = Util.JsonHelper.DeserializeJsonToList<Entity.SendDataImport>(json);
                                    if (sdi.Count > 0) p.SetValue(obj, sdi, null);
                                    break;
                                default:
                                    //注意：有在此处中断时，有自定义类型或List类型需要加入!
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(tv.ToString()))//空值
                        {
                            tv = p.PropertyType.IsValueType ? Activator.CreateInstance(p.PropertyType) : null;//值类型
                        }
                        else
                        {
                            tv = System.ComponentModel.TypeDescriptor.GetConverter(p.PropertyType).ConvertFromString(tv.ToString());    //创建对象
                        }
                        p.SetValue(obj, tv, null);
                    }

                }
            }

            return obj;
        }
        public static object HashtableToObject(Hashtable source,object obj)
        {
            //object obj = Activator.CreateInstance<object>();
            object tv;

            PropertyInfo[] ps = obj.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (PropertyInfo p in ps)
            {
                if (source.ContainsKey(p.Name))
                {
                    tv = source[p.Name];

                    if (p.PropertyType.IsArray)//数组类型,单独处理
                    {
                        //p.SetValue(obj, tv, null);
                        if (p.PropertyType == typeof(byte[]))
                        {
                            //p.SetValue(obj, Convert.FromBase64String(tv.ToString()), null);
                            try
                            {
                                p.SetValue(obj, Convert.FromBase64String(tv.ToString()), null);
                            }
                            catch
                            {
                                //兼容旧版本的测试文件中存在List<byte>的属性
                                //如:CmdCustom.Data，测试文件中旧版本采用List<byte>，现版本采用byte[]，故需再做兼容性转换
                                List<byte> by = Util.JsonHelper.DeserializeJsonToList<byte>(tv.ToString());
                                if (by.Count > 0) p.SetValue(obj, by.ToArray(), null);
                            }
                        }
                        else
                        {
                            p.SetValue(obj, tv, null);
                        }
                    }
                    else if (p.PropertyType.IsGenericType)
                    {
                        //if (p.Name == "CommandIOs")
                        //{
                        //    List<Entity.CommandIO> ios = Util.JsonHelper.DeserializeJsonToList<Entity.CommandIO>(tv.ToString());
                        //    if (ios.Count > 0)      //读入文件有参数才读取，无参数默认定义值
                        //    {
                        //        p.SetValue(obj, ios, null);
                        //    }
                        //}
                        string json = tv.ToString();
                        if (!string.IsNullOrWhiteSpace(json))
                        {

                            switch (p.PropertyType.GenericTypeArguments[0].Name)
                            {
                                case "CommandIO":
                                    //List<Entity.CommandIO> io = Util.JsonHelper.DeserializeJsonToList<Entity.CommandIO>(json);
                                    ObservableCollection<Entity.CommandIO> io = Util.JsonHelper.DeserializeJsonToCollection<Entity.CommandIO>(json);
                                    if (io.Count > 0) p.SetValue(obj, io, null);
                                    break;
                                case "ChannelBase":
                                    List<Entity.ChannelBase> ch = Util.JsonHelper.DeserializeJsonToList<Entity.ChannelBase>(json);
                                    if (ch.Count > 0) p.SetValue(obj, ch, null);
                                    break;
                                case "Byte":
                                    List<byte> by = Util.JsonHelper.DeserializeJsonToList<byte>(json);
                                    if (by.Count > 0) p.SetValue(obj, by, null);
                                    break;
                                case "String":
                                    List<string> st = Util.JsonHelper.DeserializeJsonToList<string>(json);
                                    if (st.Count > 0) p.SetValue(obj, st, null);
                                    break;
                                case "SendDataImport":
                                    List<Entity.SendDataImport> sdi = Util.JsonHelper.DeserializeJsonToList<Entity.SendDataImport>(json);
                                    if (sdi.Count > 0) p.SetValue(obj, sdi, null);
                                    break;
                                default:
                                    //注意：有在此处中断时，有自定义类型或List类型需要加入!
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(tv.ToString()))//空值
                        {
                            tv = p.PropertyType.IsValueType ? Activator.CreateInstance(p.PropertyType) : null;//值类型
                        }
                        else
                        {
                            tv = System.ComponentModel.TypeDescriptor.GetConverter(p.PropertyType).ConvertFromString(tv.ToString());    //创建对象
                        }
                        p.SetValue(obj, tv, null);
                    }

                }
            }

            return obj;
        }
        */
        
        /// <summary>
        /// Ping终端主机
        /// </summary>
        /// <param name="nameOrAddress">IP地址或计算机名</param>
        /// <returns></returns>
        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                if (nameOrAddress == "0.0.0.0")
                {
                    return false;
                }
                pinger = new Ping();
                //PingReply reply = pinger.Send(nameOrAddress);
                PingReply reply = pinger.Send(nameOrAddress, 100);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException ex)
            {
                // Discard PingExceptions and return false;
                LogHelper.WriteError(ex);
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        //public static void TextSelectAll(RichTextBox richTextBox)
        //{
        //    richTextBox.SelectAll();
        //}
        //public static void TextCopyToClipboard(RichTextBox richTextBox)
        //{
        //    Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText.Replace("\n", "\r\n"));
        //}
        //public static void TextClear(RichTextBox richTextBox)
        //{
        //    richTextBox.Clear();
        //}

        //public static string ExpressionReplace(string exp, string pattern, List<CommandBase> commands)
        //{
        //    string expression = exp;
        //    try
        //    {
        //        if (!string.IsNullOrWhiteSpace(expression) && commands.Count > 0)
        //        {
        //            //正则表达式查找匹配，并替换
        //            Match match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);

        //            while (match.Success)
        //            {
        //                string[] keys;
        //                keys = match.Value.Replace("&", "").Split(':');
        //                int cmdPos = Convert.ToInt32(Regex.Replace(keys[0], "[a-z]", "", RegexOptions.IgnoreCase));
        //                int valPos = Convert.ToInt32(Regex.Replace(keys[1], "[a-z]", "", RegexOptions.IgnoreCase));
        //                double value = 0;
        //                CommandBase command = commands.Where(cmd => cmd.Index == cmdPos - 1).FirstOrDefault();
        //                if (command != null)
        //                {
        //                    CommandIO commandIO = command.CommandIOs.Where(io => io.Index == valPos - 1).FirstOrDefault();
        //                    if (commandIO != null)
        //                    {
        //                        value = commandIO.Value;
        //                        expression = expression.Replace(match.Value, value.ToString());

        //                        match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);
        //                    }
        //                    else
        //                    {
        //                        expression = "0";
        //                        break;
        //                    }
        //                }
        //                else
        //                {
        //                    expression = "0";
        //                    break;
        //                }
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        LogHelper.WriteError(ex);
        //    }
        //    return expression;
        //}

        //public static string ExpressionReplaceFake(string exp, string pattern)
        //{
        //    string expression = exp;
        //    if (!string.IsNullOrWhiteSpace(expression))
        //    {
        //        //正则表达式查找匹配，并替换
        //        Match match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);

        //        Random rnd = new Random();

        //        while (match.Success)
        //        {
        //            string[] keys;
        //            keys = match.Value.Replace("&", "").Split(':');
        //            int cmdSort = Convert.ToInt32(Regex.Replace(keys[0], "[a-z]", "", RegexOptions.IgnoreCase));
        //            int valSort = Convert.ToInt32(Regex.Replace(keys[1], "[a-z]", "", RegexOptions.IgnoreCase));
        //            double value = 0;
        //            value = rnd.NextDouble();
        //            value = Math.Round(value * 100, 2);
        //            expression = expression.Replace(match.Value, value.ToString());

        //            match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);
        //        }
        //    }
        //    return expression;
        //}


        //public static string ExpressionFake(string exp, string pattern)
        //public static string ExpressionFake(string exp, string pattern, bool random)
        //{
        //    string expression = exp;
        //    if (!string.IsNullOrWhiteSpace(expression))
        //    {
        //        //正则表达式查找匹配，并替换
        //        Match match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);

        //        Random rnd = new Random();

        //        while (match.Success)
        //        {
        //            double value = 0;
        //            if (random)
        //            {
        //                value = rnd.NextDouble();
        //                value = Math.Round(value * 100, 2);
        //            }
        //            expression = expression.Replace(match.Value, value.ToString());

        //            match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);
        //        }
        //    }
        //    return expression;
        //}

        /// <summary>
        /// 公式计算
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        //public static double ExpressionEvaluate(string exp)
        //{
        //    double result = 0;
        //    try
        //    {
        //        ReversePolishNotation rpn = new ReversePolishNotation();
        //        rpn.Parse(exp);
        //        object val = rpn.Evaluate();
        //        result = Convert.ToDouble(val);
        //    }
        //    catch
        //    {
        //        result = 0;
        //    }
        //    return result;
        //}
        //public static object ExpressionEvaluate(string exp)
        //{
        //    object result;
        //    try
        //    {
        //        ReversePolishNotation rpn = new ReversePolishNotation();
        //        rpn.Parse(exp);
        //        result = rpn.Evaluate();
        //    }
        //    catch (Exception ex)
        //    {
        //        result = null;
        //        LogHelper.WriteError(ex);
        //    }
        //    return result;
        //}

        /// <summary>
        /// 修剪平均
        /// </summary>
        /// <param name="vals">求平均值的数组</param>
        /// <param name="per">从计算中排除数据点的分数</param>
        /// <returns></returns>
        //public static double TrimMean(double[] vals, double per)
        public static double TrimMean(this double[] vals, double per)
        {
            if (vals.Length <= 0 || per <= 0) return 0;

            int removeLen = Convert.ToInt32(vals.Length * per / 2);

            Array.Sort(vals);                                        // 升序
            vals = vals.Take(vals.Length - removeLen).ToArray();      // 移除首元素
            Array.Reverse(vals);                                     // 倒序
            vals = vals.Take(vals.Length - removeLen).ToArray();      // 移除末元素
            double sum = vals.ToList().Sum();           // 求和
            double arg = sum / vals.Length;             // 求平均
            return arg;
        }

        /// <summary>
        /// 滤除特殊符号 =,/&
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string IgnoreSpecial(this string val)
        {
            return val == null ? string.Empty : Regex.Replace(val, "[=,/&]", "");
        }

        //public static void TimeClear(ListView lvw,int index)
        //{
        //    if (lvw.SelectedItems != null)
        //    {
        //        if (lvw.SelectedItems[0].SubItems.Count >= index + 1)
        //        {
        //            lvw.SelectedItems[0].SubItems[index].Text = "0~0";
        //        }
        //        else { }
                
        //    }
        //}

        public static bool DriveExist(string driveLetter )
        {
//            string driveLetter = "D"; // 想要检测的磁盘盘符

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            bool driveExists = false;

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady && d.Name.StartsWith(driveLetter, StringComparison.OrdinalIgnoreCase))
                {
                    driveExists = true;
                    break;
                }
            }

            return driveExists;
        }

        public static string ToStr(this object obj)
        {
            if (obj is byte[] arr)
            {
                return arr.Byte2Hex(" ");
            }
            else
            {
                return obj == null ? string.Empty : obj.ToString();
            }
        }

        //public static object ExpressionEvaluate(this string exp, ConnectPro pro, Node nod, CommandBase cmd, DateTime init, out Exception err)
        //{
        //    if (string.IsNullOrEmpty(exp))
        //    {
        //        err = null;
        //        //return null;
        //        return 0;
        //    }

        //    string expression = RegexHelper.VariantReplace(exp, "@@Cursor", cmd.Index.ToString());
        //    if (pro.Config != null && pro.Config.AppVersion != null) expression = RegexHelper.VariantReplace(expression, "@@AppVersion", (pro.Config.AppVersion.Major * 1000000 + pro.Config.AppVersion.Minor * 10000 + pro.Config.AppVersion.Build * 100 + pro.Config.AppVersion.Revision).ToString());
        //    expression = RegexHelper.VariantReplace(expression, "@@Channel", pro.Connection.Channel.ToString());
        //    expression = RegexHelper.VariantReplace(expression, "@@SerialNumber", pro.Connection.SerialNumber.ToString());
        //    expression = RegexHelper.VariantReplace(expression, "@@SN", pro.Connection.RequestSN.ToString());
        //    expression = RegexHelper.VariantReplace(expression, "@@RepeatStep", cmd.RepeatCursor.ToString());
        //    expression = RegexHelper.VariantReplace(expression, nod.Commands);

        //    // 性能考虑，表达式中有含@@Result才做整个Testing的Result值
        //    if (expression.IndexOf("@@Result", StringComparison.OrdinalIgnoreCase) >= 0)
        //    {
        //        int testingResult = pro.Testing.Nodes.SelectMany(n => n.Commands).Where(c => c.Ran).SelectMany(c => c.CommandIOs).All(io => io.Result) ? 1 : 0;
        //        pro.RPN.SetVariable("@@result", testingResult);
        //        expression = RegexHelper.VariantReplace(expression, "@@Result", testingResult.ToString());
        //    }

        //    pro.RPN.InitialTime = init;

        //    pro.RPN.SendBytes = nod.Commands.Select(c => c.SendData == null ? (new byte[] { }) : c.SendData.ToArray()).ToArray();
        //    pro.RPN.ReceiveBytes = nod.Commands.Select(c => c.ReceiveData == null ? (new byte[] { }) : c.ReceiveData.ToArray()).ToArray();

        //    pro.RPN.RequestObject = nod.Commands.Select(c => c.RequestObject).ToArray();
        //    pro.RPN.ResponseObject = nod.Commands.Select(c => c.ResponseObject).ToArray();
        //    try
        //    {
        //        pro.RPN.Parse(expression);
        //        object result = pro.RPN.Evaluate();
        //        err = null;
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        err = e;
        //        //return null;
        //        return 0;
        //    }
        //}

        public static bool IsNumeric(this string value)
        {
            return value.All(char.IsNumber);
        }



    }
}
