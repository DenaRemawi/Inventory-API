using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogic.SpecificRepository
{
  public  interface ICategoryService
    {
        void Insert( Category category);
        List<Category> loadbyname(string name);
        List<Category> LoadAll();
        void Update(Category ca);
        void dellet(int id);

    }
}
