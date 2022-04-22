using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDataAccessCore.Entity
{
    [Table("Order")]
 public   class Order
    {
        public int ID { set; get; }

        [Required]
        public string CustomerName { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public int Discount { set; get; }
        public int Qty { set; get; }
        public int rate { set; get; }
        public int amount { set; get; }
        public int grossAmount { set; get; }
        public int vat { set; get; }
        public int netamount { set; get; }
        public Products productsss { get; set; }
        [ForeignKey("productsss")]
        public int product_Id { set; get; }

    }
}
