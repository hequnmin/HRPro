using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("smtp")]
    [PrimaryKey("smtpid", AutoIncrement = true)]
    public class SMTP : IDisposable
    {
        [Column(Name = "smtpid")]
        public int SmtpID { get; set; }

        [Column(Name = "smtphost")]
        public string SmtpHost { get; set; }

        [Column(Name = "smtpport")]
        public int SmtpPort { get; set; }

        [Column(Name = "credential")]
        public bool Credential { get; set; }

        [Column(Name = "fromemailaddress")]
        public string FromEmailAddress { get; set; }

        [Column(Name = "fromemaildisplayname")]
        public string FromEmailDisplayName { get; set; }

        [Column(Name = "fromemailpassword")]
        public string FromEmailPassword { get; set; }

        public SMTP()
        {
        }

        ~SMTP()
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
    }
}
