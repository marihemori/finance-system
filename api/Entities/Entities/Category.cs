using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("Category")]
    internal class Category : Base
    {
        [ForeignKey("FinanceSystem")]
        [Column(Order = 1)]

        public int IdSystem { get; set; }

        public virtual FinanceSystem FinanceSystem { get; set; }
    }
}
