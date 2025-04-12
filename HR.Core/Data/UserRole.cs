using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("userrole")]
    [PrimaryKey("userroleid", AutoIncrement = true)]
    public class UserRole : IDisposable
    {
        [Column(Name = "userroleid")]
        public int UserRoleID { get; set; }

        [Column(Name = "userid")]
        public int UserID { get; set; }

        [Column(Name = "roleids")]
        public int[] RoleIDs { get; set; }

        [Column(Name = "rolenames")]
        public string[] RoleNames { get; set; }


        public UserRole()
        {

        }

        ~UserRole()
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
