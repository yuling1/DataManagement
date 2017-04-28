using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Model
{
    public class BillingModel
    {
        [ColumnName("SOW")]
        public string SOWName { get; set; } = "No SOW";
        [ColumnName("Name")]
        public string UserName { get; set; }
        [ColumnName("Alias")]
        public string UserAlias { get; set; }
        [ColumnName("Onboard Date")]
        public string OnboardDate { get; set; }
        public string Location { get; set; }
        [ColumnName("Title")]
        public string MicroTitle { get; set; } = "No Title";
        public string Owner { get; set; }
        [ColumnName("Work date")]
        public int Workdate { get; set; }
        public double Rate { get; set; }
        public double Salary { get; set; }
        public string MetaData { get; set; }
    }
}
