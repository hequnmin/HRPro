using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PetaPoco;
using AntsResource;
using HR.Core.Data;

namespace HR.Forms
{
    public partial class EmployeeSingle : Form
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
            set { dockEmployees = value; }
        }

        private Dept parent;
        public Dept Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        private EmployeeBase oldEmployeeBase;
        public EmployeeBase OldEmployeeBase
        {
            get { return oldEmployeeBase; }
            set { oldEmployeeBase = value; }
        }

        private EmployeeBase newEmployeeBase;
        public EmployeeBase NewEmployeeBase
        {
            get { return newEmployeeBase; }
            set { newEmployeeBase = value; }
        }


        public EmployeeSingle()
        {
            InitializeComponent();
            Customize();
        }

        public void Customize()
        {
            this.Load += _Load;
            this.btnOK.Click += _OK;
            this.btnClose.Click += _Close;

        }

        private bool Valid()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeNO.Text))
            {
                MessageBox.Show($"{lblEmployeeNO.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmployeeName.Text))
            {
                MessageBox.Show($"{lblEmployeeName.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbSex.SelectedItem == null)
            {
                MessageBox.Show($"{lblSex.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbDept.SelectedItem == null)
            {
                MessageBox.Show($"{lblDept.Text} {Resources.__IsRequired}", Resources.WarningInformation, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void _Close(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void _OK(object sender, EventArgs e)
        {
            if (!Valid()) return;

            if (oldEmployeeBase == null)
            {
                Dept dept = cmbDept.SelectedItem as Dept;
                newEmployeeBase = new EmployeeBase()
                {
                    EmployeeNO = txtEmployeeNO.Text,
                    EmployeeName = txtEmployeeName.Text,
                    EmployeeCard = txtEmployeeCard.Text,
                    Sex = cmbSex.SelectedValue.ToString(),
                    Dept = dept,
                    DeptID = dept.DeptID,
                    CompanyID = dept.CompanyID,
                };

                EmployeeBases.Create(database, newEmployeeBase);
            }
            else
            {

            }

            this.DialogResult= DialogResult.OK;
        }

        private void _Load(object sender, EventArgs e)
        {
            this.cmbSex.DataSource = Sexs.GetSexs();
            this.cmbSex.DisplayMember = nameof(Sex.SexName);
            this.cmbSex.ValueMember = nameof(Sex.SexName);

            this.cmbDept.DataSource = dockEmployees.Depts;
            this.cmbDept.DisplayMember = nameof(Dept.DeptFullName);
            this.cmbDept.ValueMember = nameof(Dept.DeptID);
            this.cmbDept.SelectedItem = parent;
        }

    }
}
