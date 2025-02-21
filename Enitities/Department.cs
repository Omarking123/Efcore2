using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcore2.Enitities
{
    internal class Department
    {

        public  int Id { get; set; }
        public string DeptName { get; set; }


        //public int EmpId { get; set; }
        //public Employee? Manager { get; set; }

        public List<Employee>  Employee { get; set; }
    }
    
}
