using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("UserFinanceSystem")]
    public class UserFinanceSystem
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public bool Admin { get; set; }
        public bool ActualSystem { get; set; }

        [ForeignKey("FinanceSystem")]
        [Column(Order = 1)]
        public int IdSystem { get; set; }
        public virtual FinanceSystem FinanceSystem { get; set; }
    }
}
