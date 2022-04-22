using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  interface IProductsService
    {
        void Insert(Products p);
        List<Products> LoadAll();
        void dellet(int id);
        Products finded(int id);
    }
}
