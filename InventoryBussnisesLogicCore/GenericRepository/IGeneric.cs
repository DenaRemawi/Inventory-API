using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.GenericRepository
{
  public  interface IGeneric<T> where T:class
    {
        void Insert(T obj);
        List<T> LoadAll();
        void deletee(int id);
        void Update(T obj);
        T edit(int id);


    }
}
