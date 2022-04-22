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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService icompanyService;
        public CompanyController(ICompanyService _icompanyService)
        {
            icompanyService = _icompanyService;

        }
        [HttpPost]
        [Route("insert")]

        public void Insert(Company c)
        {
            icompanyService.Insert(c);
        }
    }
}
