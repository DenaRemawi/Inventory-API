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
    public class CountryController : ControllerBase
    {
        ICountryService icountry;
        public CountryController(ICountryService _icountryservice)
        {
            icountry = _icountryservice;

        }
        [HttpGet]
        public List<Country> countries()
        {
            return icountry.loadcountry();
        }
    }
}
