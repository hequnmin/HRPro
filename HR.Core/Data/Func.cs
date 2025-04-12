using System;
using System.Windows.Forms;
using PetaPoco;

namespace HR.Core.Data
{
    [TableName("func")]
    [PrimaryKey("funcid", AutoIncrement = true)]
    public class Func : IDisposable
    {
        [Column(Name = "funcid")]
        public int FuncID { get; set; }

        [Column(Name = "viewname")]
        public string ViewName { get; set; }

        [Column(Name = "viewtext")]
        public string ViewText { get; set; }

        [Column(Name = "funcname")]
        public string FuncName { get; set; }

        [Column(Name = "functext")]
        public string FuncText { get; set; }

        [Ignore]
        public FuncType SetFuncName { 
            set
            {
                FuncName = GetFuncName(value);
            } 
        }

        [Column(Name = "anyone")]
        public bool Anyone { get; set; }

        //[Ignore]
        //public bool Owne { get; set; }

        [Ignore]
        public FuncType FuncType { 
            get
            {
                return GetFuncType(FuncName);
            }
            set
            {
            }
        }

        public Func()
        {
        }

        public Func(string viewName, string viewText, FuncType funcType, bool anyone)
        {
            ViewName = viewName;
            ViewText = viewText;
            FuncType = funcType;
            FuncName = GetFuncName(funcType);
            FuncText = GetFuncText(funcType);

            Anyone = anyone;
        }

        ~Func()
        {

        }

        public string GetFuncName(FuncType func)
        {
            string ret = string.Empty;
            switch (func)
            {
                case FuncType.Create:
                    ret = "Create";
                    break;
                case FuncType.Retrieve:
                    ret = "Retrieve";
                    break;
                case FuncType.Update:
                    ret = "Update";
                    break;
                case FuncType.Delete:
                    ret = "Delete";
                    break;
                case FuncType.CheckIn:
                    ret = "CheckIn";
                    break;
                case FuncType.CheckOut:
                    ret = "CheckOut";
                    break;
                case FuncType.Publish:
                    ret = "Publish";
                    break;
                case FuncType.Recover:
                    ret = "Recover";
                    break;
                case FuncType.Switch:
                    ret = "Switch";
                    break;
                default:
                    break;
            }
            return ret;
        }

        public string GetFuncText(FuncType func)
        {
            string ret = string.Empty;
            switch (func)
            {
                case FuncType.Create:
                    ret = "新建";
                    break;
                case FuncType.Retrieve:
                    ret = "查看";
                    break;
                case FuncType.Update:
                    ret = "编辑";
                    break;
                case FuncType.Delete:
                    ret = "删除";
                    break;
                case FuncType.CheckIn:
                    ret = "检入";
                    break;
                case FuncType.CheckOut:
                    ret = "检出";
                    break;
                case FuncType.Publish:
                    ret = "发布";
                    break;
                case FuncType.Recover:
                    ret = "收回";
                    break;
                case FuncType.Switch:
                    ret = "启用/禁用";
                    break;
                default:
                    break;
            }
            return ret;
        }

        public string GetFuncText(FuncType func, Form form)
        {
            string ret = string.Empty;

            string funcName = GetFuncName(func);
            //查找Tag为FuncName的控件的显示文本。如果存在，取控件显示文本。
            
            foreach (Control container in form.Controls)
            {
                if (container is ToolStripContainer)
                {
                    foreach(Control panel in container.Controls)
                    {
                        if (panel is ToolStripContentPanel)
                        {
                            foreach (Control tool in panel.Controls)
                            {
                                if (tool is ToolStrip)
                                {
                                    ToolStrip toolbar = tool as ToolStrip;
                                    foreach(ToolStripItem item in toolbar.Items)
                                    {
                                        if (item.Tag != null && item.Tag.ToString() == funcName)
                                        {
                                            ret = item.Text;
                                        }
                                    }
                                    
                                }
                            }
                        }
                    }
                }
            }
            if (string.IsNullOrEmpty(ret))
            {
                ret = GetFuncText(func);
            }
            return ret;
        }

        public FuncType GetFuncType(string funcName)
        {
            FuncType type = FuncType.Retrieve;
            switch (funcName)
            {
                case "Retrieve":
                    type = FuncType.Retrieve;
                    break;
                case "Create":
                    type = FuncType.Create;
                    break;
                case "Update":
                    type = FuncType.Update;
                    break;
                case "Delete":
                    type = FuncType.Delete;
                    break;
                case "CheckIn":
                    type = FuncType.CheckIn;
                    break;
                case "CheckOut":
                    type = FuncType.CheckOut;
                    break;
                case "Publish":
                    type = FuncType.Publish;
                    break;
                case "Recover":
                    type = FuncType.Recover;
                    break;
                case "Switch":
                    type = FuncType.Switch;
                    break;
                default:
                    break;
            }
            return type;
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

    //public enum FuncType { Retrieve, Create, Update, Delete, CheckIn, CheckOut, Publish, Recover }
    //public enum FuncType { None = 0, Retrieve = 1, Create = 2, Update = 4, Delete = 8, CheckIn = 16, CheckOut = 32, Publish = 64, Recover = 128, Open = 256 }
    //public enum FuncType { None = 0, Retrieve = 1, Create = 2, Update = 4, Delete = 8, CheckIn = 16, CheckOut = 32, Publish = 64, Recover = 128 }
    public enum FuncType { None = 0, Retrieve = 1, Create = 2, Update = 4, Delete = 8, CheckIn = 16, CheckOut = 32, Publish = 64, Recover = 128, Switch = 256 }
}
