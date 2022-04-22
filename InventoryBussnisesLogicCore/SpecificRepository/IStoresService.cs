using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
 public   interface IStoresService
    {
        void Insert(Stores stores);
        List<Stores> loadbyname(string name);
        List<Stores> LoadAll();
        void Update(Stores s);
        void dellet(int id);
    }
}
