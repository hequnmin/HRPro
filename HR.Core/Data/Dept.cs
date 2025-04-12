using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PetaPoco;

namespace HR.Core.Data
{
    [TableName("dept")]
    [PrimaryKey("deptid", AutoIncrement = true)]
    public class Dept
    {
        public const string DeptFullNameDelimiter = "\\";
        public const string DeptPathDelimiter = ",";

        private int deptID;
        [Column(Name = "deptid")]
        public int DeptID
        {
            get { return deptID; }
            set
            {
                if (deptID != value)
                {
                    deptID = value;
                }
            }
        }

        [Column(Name = "deptno")]
        public string DeptNO { get; set; }

        private string deptName;
        [Column(Name = "deptname")]
        public string DeptName { 
            get { return deptName; }
            set
            {
                if (deptName != value)
                {
                    deptName = value;
                }
            }
        }

        private string deptFullName;
        [Column(Name = "deptfullname")]
        public string DeptFullName
        {
            get { return deptFullName; }
            set
            {
                if (deptFullName != value)
                {
                    deptFullName = value;
                }
            }
        }

        private string deptPath;
        [Column(Name = "deptpath")]
        public string DeptPath
        {
            get { return deptPath; }
            set
            {
                if (deptPath != value)
                {
                    deptPath = value;
                }
            }
        }

        private string sortPath;
        [Column(Name = "sortpath")]
        public string SortPath
        {
            get { return sortPath; }
            set
            {
                if (sortPath != value)
                {
                    sortPath = value;
                }
            }
        }

        private int companyID;
        [Column(Name = "companyid")]
        public int CompanyID { 
            get
            {
                return companyID;
            }
            set
            {
                if (companyID != value)
                {
                    companyID = value;
                }
            }
        }

        private int? parentID;
        [Column(Name = "parentid")]
        public int? ParentID { 
            get
            {
                return parentID;
            }
            set
            {
                if (parentID != value)
                {
                    parentID = value;
                }
            }
        }

        [Column(Name = "disused")]
        public bool Disused { get; set; }

        [Column(Name = "sortno")]
        public string SortNO { get; set; }

        [Column(Name = "remark")]
        public string Remark { get; set; }

        private Company company;
        [Ignore]
        public Company Company { 
            get
            {
                return company;
            }
            set
            {
                if (company != value)
                {
                    company = value;
                    companyID = company.CompanyID;
                }
            }
        }

        private Dept parent;
        [Ignore]
        public Dept Parent { 
            get
            {
                return parent;
            }
            set
            {
                if (parent != value)
                {
                    parent = value;
                    parentID = parent.DeptID;
                }
            }
        }

        private List<Dept> children = new List<Dept>();
        [Ignore]
        public List<Dept> Children
        {
            get
            {
                return children;
            }
            set
            {
                if (children != value)
                {
                    children = value;
                }
            }
        }


        public Dept() 
        { 
        }

        public string GetDeptFullName()
        {
            string fullname;
            if (parent != null)
            {
                fullname = parent.GetDeptFullName() + DeptFullNameDelimiter + deptName ;
            }
            else
            {
                fullname = deptName ;
            }
            return fullname;
        }

        public string GetDeptPath()
        {
            string fullpath;
            if (parent != null)
            {
                fullpath = parent.GetDeptPath() + DeptPathDelimiter + deptID;
            }
            else
            {
                fullpath = deptID.ToString();
            }
            return fullpath;
        }

        public string GetSortPath()
        {
            string fullpath;
            if (parent != null)
            {
                fullpath = parent.GetSortPath() + DeptPathDelimiter + $"{SortNO}-{deptID.ToString().PadLeft(8, '0')}";
            }
            else
            {
                fullpath = $"{SortNO}-{deptID.ToString().PadLeft(8, '0')}";
            }
            return fullpath;
        }
    }

    public class DeptSorter : IComparer<Dept>
    {
        public int Compare(Dept x, Dept y)
        {
            //return string.Compare(x.SortNO, y.SortNO, StringComparison.OrdinalIgnoreCase);

            // return -1    x 排前, y 排后
            // return 0     不变
            // return 1     x 排后, y 排前 
            return string.Compare(x.SortPath, y.SortPath, StringComparison.OrdinalIgnoreCase);
        }
    }
}
