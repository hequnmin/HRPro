using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetaPoco;

namespace HR.Core.Data
{
    public class Funcs
    {
        public Funcs() 
        { 
        }

        ~Funcs() 
        { 
        }

        //public static List<Func> GetFuncs(Database db, string viewName)
        //{
        //    Sql sql = Sql.Builder
        //        .Where("viewname = @0", viewName);
        //    List<Func> funcs = db.Fetch<Func>(sql);

        //    return funcs;
        //}

        //public static Func GetFunc(Database db, string viewName, FuncType funcType) 
        //{ 
        //    List<Func> funcs = GetFuncs(db, viewName);
        //    return funcs.FirstOrDefault(f => f.FuncType == funcType);
        //}

        public static List<Func> GetFuncs(Database db, User user)
        {
            List<Func> funcs = new List<Func>();

            if (!string.IsNullOrEmpty(user.RoleIDs))
            {
                Sql sql = Sql.Builder
                             .Append("select distinct f.*")
                             .Append("from func f")
                             .Append("left join rolefunc rf on rf.viewname = f.viewname and rf.funcname = f.funcname")
                             .Append($"where rf.roleid in ({user.RoleIDs})");
                funcs = db.Fetch<Func>(sql);
            }

            return funcs;
        }

        public static Func GetFunc(Database db, User user, string viewname, string funcname)
        {

            if (!string.IsNullOrEmpty(user.RoleIDs))
            {
                Sql sql = Sql.Builder
                             .Append("select distinct f.*")
                             .Append("from func f")
                             .Append("left join rolefunc rf on rf.viewname = f.viewname and rf.funcname = f.funcname")
                             .Append($"where rf.roleid in ({user.RoleIDs}) and rf.viewname = '{viewname}' and rf.funcname = '{funcname}'");
                Func funcs = db.Fetch<Func>(sql).FirstOrDefault();
                return funcs;
            }
            else
            {
                return null;
            }

        }
    }
}
