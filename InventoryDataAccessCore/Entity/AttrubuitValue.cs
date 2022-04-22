using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataAccessCore.Entity
{
    [Table("Attrubute-Value")]
        public class AttrubuitValue
    {
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        public Attrub attrubseAee { set; get; }

        [ForeignKey("attrubseAee")]
        public int Attrubite_ID { set; get; }


        [InverseProperty("Color")]
        public List<Products> productsColor { set; get; }


        [InverseProperty("Size")]
        public List<Products> productsSize { set; get; }

    }
}
