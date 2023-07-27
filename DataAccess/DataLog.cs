using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DataLog
    {
        public int Question { get; set; }
        public String Answers { get; set; }
        public Boolean Results { get; set; }
        public override string ToString()
        {
            return $"{Question} | {Answers} | {(Results ? "1" : "0")}";
        }
    }
}
