using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities.Dimension
{
    public class Employee : DBBasic
    {
        [Required]
        [ColumnName("Name")]
        public string UserName { get; set; }
        [ColumnName("Alias")]
        public string UserAlias { get; set; }
        
        public int BeyondSoftID { get; set; }
        public string Email { get; set; }
    }
}
