using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities.Dimension
{
    public class MSTitle : DBBasic
    {
        [Required]
        [ColumnName("Title")]
        public string MicroTitle { get; set; } = "No Title";
        public double Rate { get; set; }
        public int BillingYear { get; set; } = DateTime.Now.Year;
    }
}
