
using InventoryBussnisesLogicCore.GenericRepository;
using InventoryDataAccessCore.Context;
using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  class ProductsService :IProductsService
    {
        private readonly InventoryyContext context;
        private readonly IGeneric<Products> genericService;

        public ProductsService(InventoryyContext _context, IGeneric<Products> _generic)
        {
            context = _context;
            genericService = _generic;
        }

        public void Insert(Products p)
        {
            genericService.Insert(p);
        }
        public List<Products> LoadAll()
        {
            return genericService.LoadAll();
        }

        public void dellet(int id)
        {
            genericService.deletee(id);
        }

        public Products finded(int id)
        {
          return  context.products.Find(id);
        }
    }
}
