
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
  public  class CompanyService: ICompanyService
    {
        private readonly InventoryyContext context;
        private readonly IGeneric<Company> genericService;

        public CompanyService(InventoryyContext _context, IGeneric<Company> _generic)
        {
            context = _context;
            genericService = _generic;
        }


        public void Insert(Company co)
        {
            genericService.Insert(co);
        }
    }
}
