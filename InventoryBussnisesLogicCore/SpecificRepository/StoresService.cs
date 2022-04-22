
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
  public  class StoresService:IStoresService
    {
       private readonly InventoryyContext context;
        private readonly IGeneric<Stores> genericService;

        public StoresService(InventoryyContext _context, IGeneric<Stores> _generic)
        {
            context = _context;
            genericService = _generic;
        }

        public void Insert(Stores stores)
        {
            genericService.Insert(stores);
        }


        public List<Stores> LoadAll()
        {
            return genericService.LoadAll();
        }

        public List<Stores> loadbyname(string name)
        {
            return context.stores.Where(p => p.Name == name).ToList();
        }

        public void dellet(int id)
        {
            genericService.deletee(id);
        }


     

        public void Update(Stores s)
        {
            genericService.Update(s);
        }
    }
}
