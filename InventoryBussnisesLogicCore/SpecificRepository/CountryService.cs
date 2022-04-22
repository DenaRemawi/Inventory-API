
using InventoryDataAccessCore.Context;
using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  class CountryService : ICountryService
    {
        InventoryyContext context;
        public CountryService(InventoryyContext _contextdare)
        {
            context = _contextdare;
        }
        public List<Country> loadcountry()
        {
            List<Country> lic = context.countries.ToList();

            return lic;
        }
    }
}
