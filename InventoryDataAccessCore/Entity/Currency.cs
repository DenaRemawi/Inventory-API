using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDataAccessCore.Entity
{
    [Table("Currency")]
public    class Currency
    {
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        public Company company { set; get; }

        [ForeignKey("Company")]
        public int Company_Id {set; get;}
     
    }
}
