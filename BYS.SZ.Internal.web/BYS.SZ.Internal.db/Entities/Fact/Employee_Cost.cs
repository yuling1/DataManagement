using BYS.SZ.Internal.db.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities.Fact
{
    public class Employee_Cost : DBBasic
    {
        public int Month { get; set; } = DateTime.Now.Month;
        public double Salary { get; set; }
        [Required]
        public Employee EmployeeInfo { get; set; }
        public string MetaData { get; set; }
    }
}
