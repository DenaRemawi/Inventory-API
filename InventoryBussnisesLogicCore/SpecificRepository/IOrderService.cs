using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  interface IOrderService
    {
        void Insert(Order o);
        void dellet(int id);
        List<Order> loadbyname(string name);
        List<Order> loadAll();

        void Update(Order o);

    }
}
