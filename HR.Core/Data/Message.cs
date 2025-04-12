using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

using PetaPoco;
using AntsResource;
using System.Linq;
using AntsCore.Util;

namespace AntsCore.Entity.Data
{
    [TableName("message")]
    [PrimaryKey("message_pk", AutoIncrement = false)]
    public class Message
    {
        [LocalizedCategory("Basic"), LocalizedDisplayName("Title")]
        [Editor(typeof(UITypeEditorRichTextEditor), typeof(UITypeEditor))]
        [Column("title")]
        public string Title { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("Content")]
        [Editor(typeof(UITypeEditorRichTextEditor), typeof(UITypeEditor))]
        [Column("content")]
        public string Content { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("Tags")]
        [Column("tags")]
        public string Tags { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("Keywords")]
        [Column("keywords")]
        public string Keywords { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("UserNO")]
        [Column("userno")]
        public string UserNO { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("MachineNO")]
        [Column("machineno")]
        public string MachineNO { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("CreatedDate")]
        [Column("created")]
        public DateTime Created { get; set; }

        public Message()
        {

        }

        ~Message()
        {

        }
        /// <summary>
        /// 输出错误日志至远程数据库
        /// </summary>
        /// <param name="db">远程数据库</param>
        /// <param name="usr">登录用户</param>
        /// <param name="mac">设备编号</param>
        /// <param name="exc">错误</param>
        /// <param name="keywords">关键词</param>
        /// <returns></returns>
        public static object InsertError(Database db, User usr, Machine mac, Exception exc, params string[] keywords)
        {
            try
            {
                Message msg = new Message()
                {
                    Created = DateTime.Now,
                    Title = exc.Message,
                    Content = exc.StackTrace,
                    Tags = "Error",
                    Keywords = string.Join(",", keywords),
                    UserNO = usr.UserNO,
                    MachineNO = mac.MachineNO,
                };

                return db.Insert(msg);
            }
            catch(Exception ex)
            {
                LogHelper.WriteError(ex);
                return null;
            }
        }

        public static object InsertWarning(Database db, User usr, Machine mac, string title, string content, params string[] keywords)
        {
            try
            {
                Message msg = new Message()
                {
                    Created = DateTime.Now,
                    Title = title,
                    Content = content,
                    Tags = "Warning",
                    Keywords = string.Join(",", keywords),
                    UserNO = usr.UserNO,
                    MachineNO = mac.MachineNO,
                };

                return db.Insert(msg);
            }
            catch(Exception ex)
            {
                LogHelper.WriteError(ex);
                return null;
            }
        }

        public static object InsertInfo(Database db, User usr, Machine mac, string title, string content, params string[] keywords)
        {
            try
            {
                Message msg = new Message()
                {
                    Created = DateTime.Now,
                    Title = title,
                    Content = content,
                    Tags = "Info",
                    Keywords = string.Join(",", keywords.Where(s => !string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s))),
                    UserNO = usr?.UserNO,
                    MachineNO = mac?.MachineNO,
                };

                return db.Insert(msg);
            }
            catch(Exception ex)
            {
                LogHelper.WriteError(ex);
                return null;
            }            
        }

        public static object InsertMessage(Database db, User usr, Machine mac, string title, string content, params string[] keywords)
        {
            try
            {
                Message msg = new Message()
                {
                    Created = DateTime.Now,
                    Title = title,
                    Content = content,
                    Tags = "Message",
                    Keywords = string.Join(",", keywords),
                    UserNO = usr.UserNO,
                    MachineNO = mac.MachineNO,
                };

                return db.Insert(msg);
            }
            catch(Exception ex)
            {
                LogHelper.WriteError(ex);
                return null;
            }            
        }
    }
}
