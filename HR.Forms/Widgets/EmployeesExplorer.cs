using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using AntsResource;
using HR.Core.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HR.Forms.Widgets
{
    public partial class EmployeesExplorer : UserControl
    {
        #region 属性
        private Company company;
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
                    //DeptTree(company, depts);
                }
            }
            
        }

        private List<Dept> depts;
        public List<Dept> Depts {
            get
            {
                return depts;
            }
            set
            {
                if (depts != value)
                {
                    depts = value;
                    DeptTree();
                }
            }
        }


        #endregion

        #region 委托
        private static readonly object _eventMenuRefreshClick = new object();
        private static readonly object _eventMenuCompanySingleClick = new object();
        private static readonly object _eventMenuCompanyDeptNewClick = new object();
        private static readonly object _eventMenuDeptEditClick = new object();
        private static readonly object _eventMenuDeptNewClick = new object();
        private static readonly object _eventMenuDeptDeleteClick = new object();

        public event EventHandler MenuRefreshClick
        {
            add { this.Events.AddHandler(_eventMenuRefreshClick, value); }
            remove { this.Events.RemoveHandler(_eventMenuRefreshClick, value); }
        }
        protected virtual void OnMenuRefreshClick(EventArgs e)
        {
            EventHandler handler;
            handler = (EventHandler)this.Events[_eventMenuRefreshClick];
            handler?.Invoke(this, e);
        }

        public event EventHandler MenuCompanySingleClick
        {
            add { this.Events.AddHandler(_eventMenuCompanySingleClick, value); }
            remove { this.Events.RemoveHandler(_eventMenuCompanySingleClick, value); }
        }
        protected virtual void OnMenuCompanySingleClick(EventArgs e)
        {
            EventHandler handler;
            handler = (EventHandler)this.Events[_eventMenuCompanySingleClick];
            handler?.Invoke(this, e);
        }

        public event EventHandler MenuCompanyDeptNewClick
        {
            add { this.Events.AddHandler(_eventMenuCompanyDeptNewClick, value); }
            remove { this.Events.RemoveHandler(_eventMenuCompanyDeptNewClick, value); }
        }
        protected virtual void OnMenuCompanyDeptNewClick(EventArgs e)
        {
            EventHandler handler;
            handler = (EventHandler)this.Events[_eventMenuCompanyDeptNewClick];
            handler?.Invoke(this, e);
        }

        public event EventHandler MenuDeptEditClick
        {
            add { this.Events.AddHandler(_eventMenuDeptEditClick, value); }
            remove { this.Events.RemoveHandler(_eventMenuDeptEditClick, value); }
        }
        protected virtual void OnMenuDeptEditClick(EventArgs e)
        {
            EventHandler handler;
            handler = (EventHandler)this.Events[_eventMenuDeptEditClick];
            handler?.Invoke(this, e);
        }

        public event EventHandler MenuDeptNewClick
        {
            add { this.Events.AddHandler(_eventMenuDeptNewClick, value); }
            remove { this.Events.RemoveHandler(_eventMenuDeptNewClick, value); }
        }
        protected virtual void OnMenuDeptNewClick(EventArgs e)
        {
            EventHandler handler;
            handler = (EventHandler)this.Events[_eventMenuDeptNewClick];
            handler?.Invoke(this, e);
        }

        public event EventHandler MenuDeptDeleteClick
        {
            add { this.Events.AddHandler(_eventMenuDeptDeleteClick, value); }
            remove { this.Events.RemoveHandler(_eventMenuDeptDeleteClick, value); }
        }
        protected virtual void OnMenuDeptDeleteClick(EventArgs e)
        {
            EventHandler handler;
            handler = (EventHandler)this.Events[_eventMenuDeptDeleteClick];
            handler?.Invoke(this, e);
        }
        #endregion

        TreeNode root;
        Dictionary<int, TreeNode> nodeDict = new Dictionary<int, TreeNode>();

        public EmployeesExplorer()
        {
            InitializeComponent();

            Customize();
        }

        public void Customize()
        {
            this.Load += _Load;

            this.menuRefresh.Click += (se, ea) => OnMenuRefreshClick(ea);
            this.menuCompanySingle.Click += (se, ea) => OnMenuCompanySingleClick(ea);
            this.menuCompanyDeptNew.Click += (se, ea) => OnMenuCompanyDeptNewClick(ea);
            this.menuDeptEdit.Click += (se, ea) => OnMenuDeptEditClick(ea);
            this.menuDeptNew.Click += (se, ea) => OnMenuDeptNewClick(ea);
            this.menuDeptDelete.Click += (se, ea) => OnMenuDeptDeleteClick(ea);
        }

        private void _Load(object sender, EventArgs e)
        {

        }

        private void DeptTree()
        {
            if (company == null) return;

            nodeDict.Clear();
            TreeView.Nodes.Clear();
            root = new TreeNode()
            {
                Name = $"CompanyID={company.CompanyID}",
                Text = company.CompanyName,
                Tag = company,
                ImageKey = "information",
                SelectedImageKey = "information",
                ContextMenuStrip = menuCompany,
            };
            TreeView.Nodes.Add(root);

            if (depts != null)
            {
                foreach (Dept d in depts)
                {
                    TreeNode node = new TreeNode(d.DeptName) 
                    { 
                        Tag = d, 
                        ImageKey = "group",
                        SelectedImageKey = "group",
                        ContextMenuStrip = menuDept 
                    };

                    nodeDict[d.DeptID] = node;

                    if (d.Parent == null)
                    {
                        root.Nodes.Add(node);
                    }
                    else
                    {
                        int parentid = d.Parent.DeptID;
                        if (nodeDict.ContainsKey(parentid))
                        {
                            nodeDict[parentid].Nodes.Add(node);
                        }
                    }
                }
            }

            root.ExpandAll();
        }

        public void AddDept(Dept dept)
        {
            TreeNode node = new TreeNode(dept.DeptName) 
            { 
                Tag = dept, 
                ImageKey = "group",
                SelectedImageKey = "group",
                ContextMenuStrip = menuDept 
            };
            
            nodeDict[dept.DeptID] = node;

            if (dept.Parent == null)
            {
                root.Nodes.Add(node);
            }
            else
            {
                int parentid = dept.Parent.DeptID;
                if (nodeDict.ContainsKey(parentid))
                {
                    nodeDict[parentid].Nodes.Add(node);
                    nodeDict[parentid].Expand();
                    TreeView.SelectedNode = node;
                }
            }
        }

        public bool RemoveDept(Dept dept)
        {
            if (nodeDict.ContainsKey(dept.DeptID))
            {
                TreeView.Nodes.Remove(nodeDict[dept.DeptID]);
                nodeDict.Remove(dept.DeptID);
            }

            return true;
        }

    }

    public class DeptNodeSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            TreeNode nodeX = x as TreeNode;
            TreeNode nodeY = y as TreeNode;
            if (nodeX.Tag is Dept deptX && nodeY.Tag is Dept deptY)
            {
                return string.Compare(deptX.SortPath, deptY.SortPath, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                return 0;
            }

        }
    }
}
