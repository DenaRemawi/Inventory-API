using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
 public   interface IBrandsService
    {
        void Insert(Brands brands);
        void dellet(int id);
        List<Brands> loadbyname(string name);
        List<Brands> loadAll();

        void Update(Brands brands);
        Brands edit(int id);



    }
}
