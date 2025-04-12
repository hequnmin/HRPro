using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR.Core.Entity
{
    public class Global
    {
        public string AppPath { get; set; }

        public Global() 
        {
            AppPath = Application.StartupPath;
        }
        ~Global()
        {
        }
    }
}
