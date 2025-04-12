using System;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("role")]
    [PrimaryKey("roleid", AutoIncrement = true)]
    public class Role : IDisposable
    {
        [Column(Name = "roleid")]
        public int RoleID { get; set; }

        [Column(Name = "roleno")]
        public string RoleNO { get; set; }

        [Column(Name = "rolename")]
        public string RoleName { get; set; }

        [Column(Name = "remark")]
        public string Remark { get; set; }

        public Role()
        {

        }
        ~Role()
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
