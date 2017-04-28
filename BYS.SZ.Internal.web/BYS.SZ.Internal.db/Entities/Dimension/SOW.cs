using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities.Dimension
{
    public class SOW : DBBasic
    {
        [Required]
        [ColumnName("SOW")]
        public string SOWName { get; set; } = "No SOW";
        public DateTime StartData { get; set; } = DateTime.Now.AddYears(-1).Date;
        public DateTime EndData { get; set; } = DateTime.Now.Date;
        [ColumnName("Owner")]
        public string FTEOwnerAlias { get; set; }
        public string Type { get; set; }
    }
}
