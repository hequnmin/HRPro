using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetaPoco;

using AntsResource;

namespace HR.Core.Data
{
    public class EmployeeBases
    {
        public EmployeeBases() 
        { 
        }


        public static List<EmployeeBase> GetEmployeeBases(Database db, Company co, Dept de)
        {
            Sql sql = Sql.Builder
                .Select("emp.*, dep.*")
                .From("employeebase emp")
                .LeftJoin("dept dep").On("emp.deptid = dep.deptid")
                .Where("emp.companyid = @0", co.CompanyID);
            if (de != null)
            {
                string deptids = GetDeptIDs(de, true);
                sql.Where($" emp.deptid in ({deptids})");
            }
            return db.Query<EmployeeBase, Dept, EmployeeBase>((emp, dep) => {
                emp.Dept = dep;
                emp.DeptFullName = dep.DeptFullName;
                return emp;
            }, sql).ToList();
        }

        public static bool Create(Database db, EmployeeBase employeeBase)
        {
            try
            {
                db.Insert(employeeBase);

                employeeBase.DeptFullName = employeeBase.Dept.GetDeptFullName();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool Delete(Database db, EmployeeBase employeeBase)
        {
            try
            {
                db.Delete(employeeBase);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string GetDeptIDs(Dept dept, bool includeChildren)
        {
            string deptids = dept.DeptID.ToString();
            if (includeChildren && dept.Children.Count > 0)
            {
                foreach (Dept child in dept.Children)
                {
                    deptids += "," + GetDeptIDs(child, includeChildren);
                }
            }
            return deptids;
        }
    }
}
