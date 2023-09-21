using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_demo
{
    [Serializable]
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesigantion { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpIsPermenant { get; set; }

    }
}
