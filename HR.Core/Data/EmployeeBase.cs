using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("employeebase")]
    [PrimaryKey("employeeid", AutoIncrement = true)]
    public class EmployeeBase
    {
        private int employeeID;
        [Column(Name = "employeeid"), Browsable(false)]
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }


        private string employeeNO;
        [Column(Name = "employeeno")]
        public string EmployeeNO
        {
            get { return employeeNO; }
            set { employeeNO = value; }
        }


        private string employeeName;
        [Column(Name = "employeename")]
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }


        private string employeeCard;
        [Column(Name = "employeecard")]
        public string EmployeeCard
        {
            get { return employeeCard; }
            set { employeeCard = value; }
        }

        private string sex;
        [Column(Name = "sex")]
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private DateTime birthday;
        [Column(Name = "birthday")]
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string idNumber;
        [Column(Name = "idnumber")]
        public string IDNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        private int companyID;
        [Column(Name = "companyid")]
        [Browsable(false)]
        public int CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        private int deptID;
        [Column(Name = "deptid"), Browsable(false)]
        public int DeptID
        {
            get { return deptID; }
            set { deptID = value; }
        }

        [ResultColumn(Name = "deptfullname")]
        public string DeptFullName { get; set; }

        private Company company;
        [Ignore, Browsable(false)]
        public Company Company
        {
            get { return company; }
            set
            {
                if (company != value)
                {
                    company = value;
                    companyID = company.CompanyID;
                }
            }
        }

        private Dept dept;
        [Ignore, Browsable(false)]
        public Dept Dept
        {
            get { return dept; }
            set 
            { 
                if (dept != value)
                {
                    dept = value;
                    deptID = dept.CompanyID;
                }
            }
        }

    }
}
