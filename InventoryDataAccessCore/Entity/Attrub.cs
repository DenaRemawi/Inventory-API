using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDataAccessCore.Entity
{
    [Table("Attrubeees")]
   public class Attrub
    {
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }
        public int status { get; set; }

        public List<AttrubuitValue> attrubuitV { set; get; }
    }
}
