using System;
using System.IO;
using System.Threading.Tasks;
using log4net;

namespace HR.Core.Util
{
    public class LogHelper
    {
        //private static readonly ILog log = LogManager.GetLogger("Ants.default");
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void WriteInfo(string info)
        {
            if (log.IsInfoEnabled)
            {
                log.Info(info);
            }
        }

        //public static void WriteError(Exception ex)
        public static void WriteError(Exception ex, params string[] keywords)
        {
            if (log.IsErrorEnabled)
            {
                //log4net.ThreadContext.Properties["title"] = keywords.Count() > 0 ? keywords[0] : string.Empty;
                //log4net.ThreadContext.Properties["userno"] = keywords.Count() > 1 ? keywords[1] : string.Empty;
                //log4net.ThreadContext.Properties["machineno"] = keywords.Count() > 2 ? keywords[2] : string.Empty;
                //log4net.GlobalContext.Properties["machineno"] = keywords.Count() > 2 ? keywords[2] : string.Empty;
                //log4net.ThreadContext.Properties["created"] = DateTime.Now;
                log.Error(ex);
            }
        }

        //public static void WriteError(Exception ex, Database db, params string[] keywords)
        //{
        //    Logger logger = new Logger
        //    {
        //        Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
        //        Title = ex.Message,
        //        Content = ex.StackTrace,
        //        Tags = "Error",
        //        Keywords = string.Join(", ", keywords)
        //    };
        //    if (ex.InnerException != null)
        //    {
        //        if (ex.InnerException.Message != null) logger.Title += ex.InnerException.Message;
        //        if (ex.InnerException.StackTrace != null) logger.Content += ex.InnerException.StackTrace;
        //    }
            
        //    logger.Insert(db);
        //}
        //public static void WriteInfo(string info, Database db, params string[] keywords)
        //{
        //    Logger logger = new Logger
        //    {
        //        Created = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
        //        Title = keywords[0],
        //        Content = info,
        //        Tags = "Info",
        //        Keywords = string.Join(", ", keywords)
        //    };
        //    logger.Insert(db);
        //}
        public static void WriteFile(string fullName, string s)
        {
            try
            {
                //log4net.GlobalContext.Properties["fname"] = $"{DateTime.Now.ToString("yyyyMMddhhmm")}";
                //log4net.Config.XmlConfigurator.Configure();
                //ILog log = LogManager.GetLogger("Ants.MES");
                //foreach (IAppender appender in LogManager.GetAllRepositories()[0].GetAppenders())
                //{
                //    var rollingFile = appender as RollingFileAppender;
                //    if (rollingFile != null)
                //    {
                //        rollingFile.File = $"{DateTime.Now.ToString("yyyyMMddhhmm")}.txt";
                //        rollingFile.ActivateOptions();
                //    }
                //}
                //log.Info(s);
                FileInfo fileInfo = new FileInfo(fullName);
                if (FileHelper.IsExistDirectory(fileInfo.Directory.ToString()))
                {
                    if (FileHelper.IsExistFile(fullName))
                    {
                        FileHelper.AppendText(fullName, s);
                    }
                    else
                    {
                        FileHelper.WriteText(fullName, s);
                    }
                }
                else
                {
                    FileHelper.CreateDirectory(fileInfo.Directory.ToString());
                    if (FileHelper.IsExistDirectory(fileInfo.Directory.ToString()))
                    {
                        if (FileHelper.IsExistFile(fullName))
                        {
                            FileHelper.AppendText(fullName, s);
                        }
                        else
                        {
                            FileHelper.WriteText(fullName, s);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteError(ex);
            }
        }
        public static async Task CleanFileAsync(string filePath, double days)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (!Directory.Exists(filePath))
                    {
                        return;
                    }
                    DirectoryInfo dir = new DirectoryInfo(filePath);
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        //if (!FileHelper.IsFileLocked(file.FullName) && file.LastWriteTime < DateTime.Now.AddSeconds(-60))
                        //if (file.LastWriteTime < DateTime.Now.AddDays(-days) && FileHelper.IsFileLocked(file.FullName))
                        if (file.LastWriteTime < DateTime.Now.AddDays(-days) && !FileHelper.IsFileLocked(file.FullName))
                        {
                            file.Delete();
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.WriteError(ex);
                }
            });
        }
    }
}
