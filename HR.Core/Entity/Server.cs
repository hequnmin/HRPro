using System;
using System.IO;
using Newtonsoft.Json;
using Npgsql;

using HR.Core.Util;

namespace HR.Core.Entity
{
    [Serializable]
    public class Server : IDisposable
    {
        public bool Online { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }

        private string databaseName = "ate2020";
        public string DatabaseName { 
            get
            {
                return databaseName;
            }
            set
            {
                if (databaseName != value) databaseName = value;
            }
        }

        public string DatabaseUserID { get; set; }
        public string DatabasePassword { get; set; }

        [JsonIgnore]
        public string ApplicationName { get; set; }

        //[JsonIgnore]
        //public string Provider { get
        //    {
        //        return "Npgsql";
        //    }
        //    private set
        //    {
        //    }
        //} 
        private string provider = "Npgsql";
        public string Provider
        {
            get
            {
                return provider;
            }
            set
            {
                provider = value;
            }
        }


        //[JsonIgnore]
        //public string ConnectionString { 
        //    get
        //    {
        //        //string password = GetPassword();
        //        //return $"HOST={Host};PORT={Port};DATABASE={DatabaseName};USER ID={DatabaseUserID};PASSWORD={password};APPLICATIONNAME={ApplicationName};";
        //        if (provider == "Npgsql")
        //        {
        //            string password = GetPassword();
        //            return $"HOST={Host};PORT={Port};DATABASE={DatabaseName};USER ID={DatabaseUserID};PASSWORD={password};APPLICATIONNAME={ApplicationName};";
        //        }
        //        else if (provider.StartsWith("SQLite"))
        //        {
        //            return $"Data Source={DataSource};Version=3;";
        //        }
        //        else
        //        {
        //            return string.Empty;
        //        }
        //    }
        //}

        private string databasePath = Path.Combine(Comm.DriveExist("D") ? $"D:\\" : $"C:\\", $"Database");
        public string DatabasePath { 
            get
            {
                return databasePath;
            }
            set
            {
                if (databasePath != value) databasePath = value;
            }
        }

        [JsonIgnore]
        public string DataSource
        {
            get
            {
                if (provider == "Npgsql")
                {
                    return string.Empty;
                }
                else if (provider.StartsWith("SQLite"))
                {
                    //return Path.Combine(DatabasePath, $"{DatabaseName}.db");
                    return Path.Combine(DatabasePath, DatabaseName.EndsWith(".db") ? DatabaseName : $"{DatabaseName }.db");
                }
                else
                {
                    return string.Empty;
                }

            }
        }

        private int keepDays = 30;
        public int KeepDays { 
            get
            {
                return keepDays;
            }
            set
            {
                if (keepDays != value) keepDays = value;
            }
        }

        public string DefaultUserNO { get; set; }

        public Server()
        {
        }

        ~Server()
        {
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //执行基本的清理代码
            }
        }

        //public void Open()
        //{
        //    if (provider == "Npgsql")
        //    {
        //        using (NpgsqlConnection cn = new NpgsqlConnection(ConnectionString))
        //        {
        //            try
        //            {
        //                cn.Open();
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //        }
        //    }
        //    else if (provider.StartsWith("SQLite"))
        //    {
        //        using (SQLiteConnection cn = new SQLiteConnection(ConnectionString))
        //        {
        //            try
        //            {
        //                cn.Open();
        //            }
        //            catch (Exception ex)
        //            {
        //                throw ex;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("非法数据库提供者！");
        //    }
        //}

        public bool ConnectionTesting()
        {
            bool connected = false;

            //using (NpgsqlConnection cn = new NpgsqlConnection(ConnectionString))
            using (NpgsqlConnection cn = new NpgsqlConnection(ConnectionString()))
            {
                try
                {
                    cn.Open();
                    connected = true;
                }
                catch
                {
                    connected = false;
                }
            }
            return connected;
        }
    
        public void SetPassword(string password)
        {
            DatabasePassword = CryptoHelper.Md5Encrypt(password);
        }

        public string GetPassword()
        {
            if (string.IsNullOrEmpty(DatabasePassword)) return string.Empty;
            return CryptoHelper.Md5Decrypt(DatabasePassword);
        }
        public string ConnectionString(string appname = null)
        {
            if (provider == "Npgsql")
            {
                string password = GetPassword();
                if (string.IsNullOrEmpty(appname))
                {
                    return $"HOST={Host};PORT={Port};DATABASE={DatabaseName};USER ID={DatabaseUserID};PASSWORD={password};APPLICATIONNAME={ApplicationName};";
                }
                else
                {
                    return $"HOST={Host};PORT={Port};DATABASE={DatabaseName};USER ID={DatabaseUserID};PASSWORD={password};APPLICATIONNAME={appname};";
                }
            }
            else if (provider.StartsWith("SQLite"))
            {
                return $"Data Source={DataSource};Version=3;";
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
