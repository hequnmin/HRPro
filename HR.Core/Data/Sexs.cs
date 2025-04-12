using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Data
{
    public class Sexs
    {
        public Sexs() { 
        }

        public static List<Sex> GetSexs()
        {
            return new List<Sex>() { new Sex(1, "男"), new Sex(2, "女") };
        }
    }
}
