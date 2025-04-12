using System;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("rolefunc")]
    [PrimaryKey("rolefuncid")]
    public class RoleFunc : IDisposable
    {
        [Column(Name = "roleid")]
        public int RoleID { get; set; }

        [Ignore]
        public Role Role { get; set; }

        [Column(Name = "viewname")]
        public string ViewName { get; set; }

        [Column(Name = "funcname")]
        public string FuncName { get; set; }

        public RoleFunc()
        {

        }

        ~RoleFunc()
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
