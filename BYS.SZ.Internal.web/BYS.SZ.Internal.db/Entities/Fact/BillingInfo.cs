using BYS.SZ.Internal.db.Entities.Dimension;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities.Fact
{
    public class BillingInfo : DBBasic
    {
        [Required]
        public Employee Employee { get; set; }
        [ColumnName("SOW")]
        public SOW Billing_SOW { get; set; }
        public int BillingMonth { get; set; } = DateTime.Now.Month;
        public MSTitle Title { get; set; }
        public string Location { get; set; }

    }
}
