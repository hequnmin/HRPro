using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using PetaPoco;
using AntsResource;

namespace HR.Core.Data
{
    public class Depts
    {
        public Depts() 
        { 
        }

        public static List<Dept> GetDepts(Database db, Company company)
        {
            List<Dept> depts = new List<Dept>();
            Sql sql = Sql.Builder
                .Select("dep.*, cmp.*")
                .From("dept dep")
                .LeftJoin("company cmp").On("dep.companyid = cmp.companyid")
                .Where("cmp.companyid = @0", company.CompanyID);
            depts = db.Query<Dept, Company, Dept>((dep, cmp) => {
                dep.Company = cmp;
                return dep;
            }, sql).ToList();
            if (depts != null)
            {
                // 赋值父级和子级对象
                foreach (Dept dept in depts)
                {
                    if (dept.ParentID != null && dept.ParentID > 0)
                    {
                        Dept parent = depts.FirstOrDefault(d => dept.ParentID == d.DeptID);
                        dept.Parent = parent;
                        if (parent != null)
                        {
                            parent.Children.Add(dept);
                        }
                    }
                }
            }
            depts = depts.OrderBy(d => d.SortPath).ToList();

            return depts;
        }

        public static bool Create(Database db, Dept dept)
        {
            try
            {
                db.Insert(dept);

                if (dept.DeptID > 0)
                {
                    if (dept.Parent != null)
                    {
                        dept.Parent.Children.Add(dept);
                    }

                    dept.DeptPath = dept.GetDeptPath();
                    dept.DeptFullName = dept.GetDeptFullName();
                    dept.SortPath = dept.GetSortPath();
                    db.Update(dept);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static bool Update(Database db, Dept dept, Dept beforeParent)
        {
            try
            {
                db.Update(dept);
                if (beforeParent != null && dept.Parent != null && beforeParent.DeptID != dept.Parent.DeptID)
                {
                    beforeParent.Children.Remove(dept);
                    dept.Parent.Children.Add(dept);
                }
                
                UpdateFullName(db, dept);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private static void UpdateFullName(Database db, Dept dept)
        {
            dept.DeptPath = dept.GetDeptPath();
            dept.DeptFullName = dept.GetDeptFullName();
            dept.SortPath = dept.GetSortPath();
            db.Update(dept);

            if (dept.Children.Count > 0)
            {
                foreach(Dept child in dept.Children)
                {
                    UpdateFullName(db, child);
                }
            }
        }

        public static bool Delete(Database db, Dept dept)
        {
            if (dept.Children.Count > 0)
            {
                MessageBox.Show(Resources.__SubitemsExist + Resources.__RemovalFailed, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                db.Delete(dept);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorInformation, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
