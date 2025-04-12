using System;
using System.ComponentModel;

using PetaPoco;
using PetaPoco.Core;
using PetaPoco.Providers;
using AntsResource;
using System.Drawing.Design;

namespace HR.Core.Data
{
    [TableName("logger")]
    [PrimaryKey("loggerid", AutoIncrement = true)]
    public class Logger
    {
        [LocalizedCategory("Basic"), LocalizedDisplayName("LoggerID"), Browsable(false)]
        [Column("loggerid")]
        public long LoggerID { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("CreatedDate")]
        [Column("created")]
        public string Created { get; set; }

        [LocalizedCategory("Basic"), LocalizedDisplayName("UserName")]
        [Column("username")]
        public string UserName { get; set; }

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

        public Logger()
        {

        }

        ~Logger()
        {

        }

        public static bool CreateTable(Database db)
        {
            IProvider provider = db.Provider;

            try
            {
                if (provider is SQLiteDatabaseProvider)
                {
                    Sql sql = Sql.Builder
                        .Append(
                            "CREATE TABLE IF NOT EXISTS Logger" +
                            "(" +
                            "    LoggerID INTEGER NOT NULL," +
                            "    Created TEXT NOT NULL," +
                            "    Title TEXT NOT NULL," +
                            "    Content TEXT NULL," +
                            "    UserName TEXT NULL," +
                            "    Tags TEXT NULL," +
                            "    Keywords TEXT NULL," +
                            "    PRIMARY KEY(LoggerID)" +
                            ")"
                        );

                    db.Execute(sql);
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public object Insert(Database db)
        {
            object result;
            try
            {
                result = db.Insert(this);
            }
            catch
            {
                return null;
            }
            return result;
        }

    }
}
