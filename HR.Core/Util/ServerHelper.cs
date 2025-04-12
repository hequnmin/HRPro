using System;
using System.IO;
using Newtonsoft.Json;


using HR.Core.Entity;
using HR.Core.Data;

namespace HR.Core.Util
{
    public static class ServerHelper
    {
        public static bool Create(string filename, Server server)
        {
            string filePath = Path.GetDirectoryName(filename);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            try
            {
                File.WriteAllText(filename, JsonConvert.SerializeObject(server));
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool Save(string filename, Server server)
        {
            string filePath = Path.GetDirectoryName(filename);

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            try
            {
                File.WriteAllText(filename, JsonConvert.SerializeObject(server));
            }
            catch
            {
                return false;
            }

            return true;
        }

        ////public static Server Load(string filename)
        ////public static Server Load(string filename, string appname)
        //public static Server Load(string filename, Online online)
        //{
        //    Server database = new Server();
        //    if (Util.FileHelper.IsExistFile(filename))
        //    {
        //        database = Util.JsonHelper.DeserializeFile<Server>(filename);
        //        //database.ApplicationName = JsonConvert.SerializeObject(online);
        //        database.ApplicationName = online == null ? "0" : online.OnlineID.ToString();
        //        return database;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public static Server Load(string filename)
        {
            Server database = new Server();
            if (FileHelper.IsExistFile(filename))
            {
                database = Util.JsonHelper.DeserializeFile<Server>(filename);
                return database;
            }
            else
            {
                return null;
            }
        }
        //public static Server Load(string filename, Online online)
        //{
        //    Server database = Load(filename);
        //    if (database != null) database.ApplicationName = online == null ? "0" : online.OnlineID.ToString();
        //    return database;
        //}
        //public static Server Load(string filename, string appname, Online online)
        public static Server Load(string filename, string appname)
        {
            Server srv = Load(filename);
            if (srv != null)
            {
                srv.ApplicationName = appname;
            }
            return srv;
        }
        public static Server Load(string filename, string appname, Online online, User user)
        {
            Server srv = Load(filename);
            if (srv != null)
            {
                srv.ApplicationName = appname;
                if (online != null && online.OnlineID > 0)
                {

                    srv.ApplicationName += $" - Online:{online.OnlineID}";
                    if (user != null)
                    {
                        srv.ApplicationName += $",User:{user.UserNO}";
                    }
                }
            }
            return srv;
        }
    }
}
