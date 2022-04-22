using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InventoryDataAccessCore.Entity
{
    [Table("Country")]
 public   class Country
    {
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

          public List<Company> companies { set; get; }
    }

}
