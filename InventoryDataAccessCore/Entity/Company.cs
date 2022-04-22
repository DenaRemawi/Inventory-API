using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDataAccessCore.Entity
{
    [Table("Company")]
 public   class Company
    {
        public int ID { set; get; }

       [Required]
        public string Name { set; get; }
         public string Charge_Amount { set; get; }
        public string Vat_Charge { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Message { set; get; }

        public Country country { set; get; }

        [ForeignKey("Country")]
        public int ciuntry_id { set; get; }

        public List<Currency> currencies { set; get; }

    }
}
