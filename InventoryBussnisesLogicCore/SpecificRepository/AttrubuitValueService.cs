
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
  public  class AttrubuitValueService: IAttrubuitValueService
    {
        private readonly InventoryyContext context;
        private readonly IGeneric<AttrubuitValue> genericService;
        public AttrubuitValueService(InventoryyContext _context, IGeneric<AttrubuitValue> _generic)
        {
            context = _context;
            genericService = _generic;
        }


        public void Insert(AttrubuitValue v)
        {
            genericService.Insert(v);
        }

        public void dellet(int id)
        {
            genericService.deletee(id);
        }

        public List<AttrubuitValue> Loadall(int A_ID)
        {
            List<AttrubuitValue> liattribute = context.attrubuitValues.Where(a => a.Attrubite_ID == A_ID).ToList<AttrubuitValue>();
            return liattribute;
        }

        public List<AttrubuitValue> loadbyname(string name)
        {
            return context.attrubuitValues.Where(p => p.Name == name).ToList();
        }
        public void update(AttrubuitValue attributeValue)
        {
            genericService.Update(attributeValue);
        }


      


    }
}

