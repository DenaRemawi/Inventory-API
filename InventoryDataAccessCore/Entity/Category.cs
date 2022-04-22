using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataAccessCore.Entity
{
    [Table("Category")]
 public   class Category
    {
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        public int Status { set; get; }

        public List<Products> products { set; get; }

    }
}
