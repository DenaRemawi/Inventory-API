using InventoryBussnisesLogicCore.GenericRepository;
using InventoryBussnisesLogicCore.SpecificRepository;
using InventoryBussnisesLogicCore.Vm;
using InventoryDataAccessCore.Context;
using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryBussnisesLogicCore.SpecificRepository
{
    public class AttrubService : IAttrubService
    {
        private readonly InventoryyContext context;
      //  private readonly IAttrubService attrubService;
        private readonly IGeneric<Attrub> genericService;




        public AttrubService(InventoryyContext _context, IGeneric<Attrub> _generic)
        {
            context = _context;
            genericService = _generic;

        }
        public List<VMAtrrbute> loadall()
        {
            List<VMAtrrbute> listVM = context.attributes.Select(data =>
            new VMAtrrbute()
            {
                Attrubbb = data,
                Count = data.attrubuitV.Count()
            }
            ).ToList();
            return listVM;

        }

    }
} 
