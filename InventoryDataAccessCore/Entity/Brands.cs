using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDataAccessCore.Entity
{
    [Table("Brands")]
 public   class Brands
    {
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        public int Status { set; get; }

        public List <Products> products { set; get; }
    }
}
