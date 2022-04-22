
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
 
      public  class OrderService : IOrderService
    {
        private readonly InventoryyContext context;
        private readonly IGeneric<Order> genericService;

        public OrderService(InventoryyContext _context, IGeneric<Order> _generic)
        {
            context = _context;
            genericService = _generic;
        }


        public void Insert(Order o)
        {
            genericService.Insert(o);
        }


        public List<Order> loadAll()
        {
            List<Order> y = genericService.LoadAll();
            return y;
        }

        public List<Order> loadbyname(string name)
        {
            return context.orders.Where(p => p.CustomerName == name).ToList();
        }

        public void dellet(int id)
        {
            genericService.deletee(id);
        }

        public void Update(Order o)
        {
            genericService.Update(o);
        }


    }
}

