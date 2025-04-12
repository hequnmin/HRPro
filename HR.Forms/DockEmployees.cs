using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using PetaPoco;
using AntsResource;
using HR.Core.Data;

namespace HR.Forms
{
    public partial class DockEmployees : ToolWindow //Form
    {
        private Database database;
        public Database Database
        {
            get { return database; }
            set { database = value; }
        }

        private Company company;
        public Company Company
        {
            get => company;
            set => company = value;
        }

        private List<Dept> depts;
        public List<Dept> Depts
        {
            get => depts;
            private set => depts = value;
        }

        #region 委托
        private static readonly object _eventAfterSelect = new object();
        public event TreeViewEventHandler AfterSelect
        {
            add { this.Events.AddHandler(_eventAfterSelect, value); }
            remove { this.Events.RemoveHandler(_eventAfterSelect, value); }
        }
        protected virtual void OnAfterSelect(TreeViewEventArgs e)
        {
            TreeViewEventHandler handler;
            handler = (TreeViewEventHandler)this.Events[_eventAfterSelect];
            handler?.Invoke(this, e);
        }
        #endregion
        public DockEmployees()
        {
            InitializeComponent();

            Customize();
        }

        public void Customize()
        {
            this.Load += _Load;
            this.employeesExplorer.MenuRefreshClick += EmployeesExplorer_MenuRefreshClick;
            this.employeesExplorer.MenuCompanySingleClick += EmployeesExplorer_MenuCompanySingleClick;
            this.employeesExplorer.MenuCompanyDeptNewClick += EmployeesExplorer_MenuDeptNewClick;
            this.employeesExplorer.MenuDeptEditClick += EmployeesExplorer_MenuDeptEditClick;
            this.employeesExplorer.MenuDeptNewClick += EmployeesExplorer_MenuDeptNewClick;
            this.employeesExplorer.MenuDeptDeleteClick += EmployeesExplorer_MenuDeptDeleteClick;
            this.employeesExplorer.TreeView.AfterSelect += (se, ea) => OnAfterSelect(ea);
        }

        private void _Load(object sender, EventArgs e)
        {
            LoadDepts();
        }

        private void LoadDepts()
        {
            depts = HR.Core.Data.Depts.GetDepts(database, company);
            employeesExplorer.Company = company;
            employeesExplorer.Depts = depts;
        }

        private void EmployeesExplorer_MenuRefreshClick(object sender, EventArgs e)
        {
            LoadDepts();
        }

        private void EmployeesExplorer_MenuCompanySingleClick(object sender, EventArgs e)
        {
            CompanySingle companySingle = new CompanySingle()
            {
                Database = Database,
                Company = Company,
            };
            if (companySingle.ShowDialog() == DialogResult.OK)
            {
                Company = companySingle.Company;
            }
        }

        private void EmployeesExplorer_MenuDeptEditClick(object sender, EventArgs e)
        {
            if (employeesExplorer.TreeView.SelectedNode.Tag is Dept dp)
            {
                //TreeNode node = employeesExplorer.TreeView.SelectedNode;
                DeptSingle deptSingle = new DeptSingle()
                {
                    Database = database,
                    Company = company,
                    Parents = depts,
                    Parent = dp.Parent,
                    Dept = dp,
                };
                if (deptSingle.ShowDialog() == DialogResult.OK)
                {
                    //node.Text = deptSingle.Dept.DeptName;
                    //node.Tag = deptSingle.Dept;
                    employeesExplorer.RemoveDept(deptSingle.Dept);
                    employeesExplorer.AddDept(deptSingle.Dept);
                }
            }
            
        }


        private void EmployeesExplorer_MenuDeptNewClick(object sender, EventArgs e)
        {
            DeptSingle deptSingle = new DeptSingle()
            {
                Database = database,
                Company = company,
            };

            if (employeesExplorer.TreeView.SelectedNode.Tag is Company)
            {
                deptSingle.Parents = null;
                deptSingle.Parent = null;
                deptSingle.Dept = null;
            }
            else if (employeesExplorer.TreeView.SelectedNode.Tag is Dept dp)
            {
                deptSingle.Parents = depts;
                deptSingle.Parent = dp;
                deptSingle.Dept = null;
            }
            else
            {
                return;
            }

            if (deptSingle.ShowDialog() == DialogResult.OK)
            {
                depts.Add(deptSingle.Dept);
                employeesExplorer.AddDept(deptSingle.Dept);
            }

        }

        private void EmployeesExplorer_MenuDeptDeleteClick(object sender, EventArgs e)
        {
            if (employeesExplorer.TreeView.SelectedNode.Tag is Dept dp)
            {
                if (HR.Core.Data.Depts.Delete(database, dp))
                {
                    employeesExplorer.RemoveDept(dp);
                }
            }
        }

    }
}
