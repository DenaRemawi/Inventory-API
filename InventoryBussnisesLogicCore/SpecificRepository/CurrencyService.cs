
using InventoryDataAccessCore.Context;
using InventoryDataAccessCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
  public  class CurrencyService : ICurrencyService
    {
        InventoryyContext context;
        public CurrencyService(InventoryyContext _contextdare)
        {
            context = _contextdare;
        }
        public List<Currency> loadCurrency()
        {
            List<Currency> lic = context.currencies.ToList();

            return lic;
        }
    }
}
