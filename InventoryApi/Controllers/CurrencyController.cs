using InventoryBussnisesLogic.SpecificRepository;
using InventoryBussnisesLogicCore.SpecificRepository;
using InventoryDataAccessCore.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CurrencyController : ControllerBase
    {
        ICurrencyService icurrency;
        public CurrencyController(ICurrencyService _currencyService)
        {
            icurrency = _currencyService;

        }
        [HttpGet]
        public List<Currency> currenciess()
        {
            return icurrency.loadCurrency();
        }
    }
}
