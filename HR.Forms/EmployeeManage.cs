using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AntsResource;
using HR.Core.Data;
using HR.Core.Util;
using PetaPoco;

namespace HR.Forms
{
    public partial class EmployeeManage : DocumentWindow //Form
    {

        private Database database;
        public Database Database
        {
            get { return database; }
            set { database = value; }
        }

        private DockEmployees dockEmployees;
        public DockEmployees DockEmployees
        {
            get { return dockEmployees; }
            set { 
                if (dockEmployees != value)
                {
                    dockEmployees = value;
                    dockEmployees.AfterSelect -= DockEmployees_AfterSelect;
                    dockEmployees.AfterSelect += DockEmployees_AfterSelect;
                }
            }
        }

        private List<Dept> depts;
        public List<Dept> Depts
        {
            get { return depts; }
            set { depts = value; }
        }


        //private List<EmployeeBase> employeeBases;
        //public List<EmployeeBase> EmployeeBases
        //{
        //    get { return employeeBases; }
        //    private set { employeeBases = value; }
        //}

        private BindingList<EmployeeBase> employeeBasesBinding;


        public EmployeeManage()
        {
            InitializeComponent();

            Customize();
        }

        private void Customize()
        {
            this.Load += _Load;
           
        }

        private void DockEmployees_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is Company co)
            {
                LoadEmployeeBases(dockEmployees.Company, null);
            } 
            else if (e.Node.Tag is Dept de)
            {
                LoadEmployeeBases(dockEmployees.Company, de);
            }
        }

        private void _Delete(object sender, EventArgs e)
        {
            //
            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    EmployeeBase emp = row.DataBoundItem as EmployeeBase;
                    if (HR.Core.Data.EmployeeBases.Delete(database, emp))
                    {
                        employeeBasesBinding.Remove(emp);
                    }
                }
            }
        }

        private void _Create(object sender, EventArgs e)
        {
            EmployeeSingle employeeSingle = new EmployeeSingle()
            {
                Database = database,
                DockEmployees = dockEmployees,
            };
            if (employeeSingle.ShowDialog() == DialogResult.OK)
            {
                employeeBasesBinding.Add(employeeSingle.NewEmployeeBase);
            }
        }

        private void _Load(object sender, EventArgs e)
        {
            this.btnRefresh.Click += (se, ea) => LoadEmployeeBases(dockEmployees.Company, null);
            this.btnCreate.Click += _Create;
            this.btnDelete.Click += _Delete;

            LoadEmployeeBases(dockEmployees.Company, null);

        }

        private void LoadEmployeeBases(Company co, Dept de)
        {
            List<EmployeeBase> employeeBases = HR.Core.Data.EmployeeBases.GetEmployeeBases(database, co, de);

            employeeBasesBinding = new BindingList<EmployeeBase>();
            foreach (EmployeeBase emp in employeeBases)
            {
                employeeBasesBinding.Add(emp);
            }

            dataGridView.Rows.Clear();
            dataGridView.DataSource = employeeBasesBinding;    

        }
    }
}
