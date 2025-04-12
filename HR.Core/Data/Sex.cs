using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Data
{
    public class Sex
    {
        public int SexID { get; set; }
        public string SexName { get; set; }

        public Sex(int id, string name) 
        { 
            SexID = id;
            SexName = name;
        }
    }
}
