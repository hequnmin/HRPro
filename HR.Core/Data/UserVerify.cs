using System;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("userverify")]
    [PrimaryKey("userverifyid", AutoIncrement = true)]
    public class UserVerify : IDisposable
    {
        [Column(Name = "userverifyid")]
        public int UserVerifyID { get; set; }

        [Column(Name = "userid")]
        public int UserID { get; set; }

        [Column(Name = "email")]
        public string EMail { get; set; }

        [Ignore]
        public User User { get; set; }

        [Column(Name = "verifytime")]
        public DateTime VerifyTime { get; set; }

        [Column(Name = "verifycode")]
        public string VerifyCode { get; set; }

        [Column(Name = "completed")]
        public bool Completed { get; set; }

        public UserVerify()
        {
        }

        ~UserVerify()
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
