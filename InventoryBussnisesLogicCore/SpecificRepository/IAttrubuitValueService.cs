using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  interface IAttrubuitValueService
    {
        void Insert(AttrubuitValue v);
        void dellet(int id);
        List<AttrubuitValue> loadbyname(string name);
        List<AttrubuitValue> Loadall(int A_ID);
        void update(AttrubuitValue attributeValue);
    }
}
