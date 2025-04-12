using System;
using System.Collections.Generic;
using HR.Core.Util;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("user")]
    [PrimaryKey("userid", AutoIncrement = true)]
    public class User : IDisposable
    {
        [Column(Name = "userid")]
        public int UserID { get; set; }

        [Column(Name = "userno")]
        public string UserNO { get; set; }

        [Column(Name = "username")]
        public string UserName { get; set; }

        [Column(Name = "email")]
        public string Email { get; set; }

        [Column(Name = "password")]
        public string Password { get; set; }

        [Ignore]
        public string RoleIDs { get; set; }

        [Ignore]
        public string RoleNames { get; set; }

        [Column(Name = "disable")]
        public bool Disable { get; set; }

        [Column(Name = "lastlogin")]
        public DateTime? LastLogin { get; set; }

        [Column(Name = "remark")]
        public string Remark { get; set; }

        [Ignore]
        public List<Role> Roles { get; set; }

        [Ignore]
        public List<Func> Funcs { get; set; }

        [Ignore]
        public string DisplayName { get => $"{UserName}<{Email}>"; }
        public User()
        {
            Roles = new List<Role>();
            Funcs = new List<Func>();
        }

        ~User()
        {
        }

        public override string ToString()
        {
            //return base.ToString();
            return UserName ?? string.Empty;
        }

        public void SetPassword(string password)
        {
            Password = CryptoHelper.Md5Encrypt(password);
        }

        public string GetPassword()
        {
            if (string.IsNullOrEmpty(Password)) return string.Empty;
            return CryptoHelper.Md5Decrypt(Password);
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
