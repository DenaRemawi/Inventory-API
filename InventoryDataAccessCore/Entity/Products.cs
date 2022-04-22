using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryDataAccessCore.Entity
{
    [Table("Products")]
  public  class Products
    {
        public int ID { set; get; }

        public string Path { set; get; }

     /*   [NotMapped]
       public IFormFile Image { set; get; }*/


        [Required]
        public string Name { set; get; }
     public int Qty { set; get; }

        public string Sku { set; get; }   
        public int Price { set; get; }

        public string Description { set; get; }
 
        public int Avability { set; get; }
        // public string size { set; get; }


        // public string color { set; get; }

        //Order
        public List<Order> or { set; get; }

        //Brands
        public Brands brand { set; get; }

        [ForeignKey("brand")]
        public int Brands_Id { set; get; }


        //Category
        public Category categories { set; get; }

        [ForeignKey("categories")]
        public int Category_Id { set; get; }


        //Store
        public Stores store { set; get; }

        [ForeignKey("store")]
        public int Stores_Id { set; get; }

        //AttrubuteValue
      [ForeignKey("Size")]
       public int size_Id { set; get; }
        public AttrubuitValue Size { set; get; }

        [ForeignKey("Color")]
        public int Color_Id { set; get; }
        public AttrubuitValue Color { set; get; }
     
    }
}
