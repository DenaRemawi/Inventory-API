
using InventoryBussnisesLogicCore.GenericRepository;
using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccessCore.Context;


namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  class BrandsService:IBrandsService
    {
        private readonly InventoryyContext context;
        private readonly IGeneric<Brands> genericService;

        public BrandsService(InventoryyContext _context ,  IGeneric<Brands> _generic)
        {
            context = _context;
            genericService = _generic;
        }


        public void Insert(Brands brands)
        {
            genericService.Insert(brands);
        }


        public List<Brands> loadAll()
        {
            List<Brands> y= genericService.LoadAll();
            return y;
        }

        public List<Brands> loadbyname(string name)
        {
            return context.brands.Where(p => p.Name == name).ToList();
        }

        public void dellet(int id)
        {
            genericService.deletee(id);
        }

            public void Update(Brands brands)
            {
                genericService.Update(brands);
            }


        public Brands edit(int id) 
        {
            return genericService.edit(id);
                
        }
      
    }
}
