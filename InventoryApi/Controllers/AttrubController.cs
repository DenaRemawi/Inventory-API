using InventoryBussnisesLogicCore.SpecificRepository;
using InventoryBussnisesLogicCore.Vm;
using InventoryDataAccessCore.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttrubController : ControllerBase
    {
        private readonly IAttrubService attrubService;
        public AttrubController(IAttrubService _Attrubuteservice)
        {
            attrubService = _Attrubuteservice;

        }


        [HttpGet]
        [Route("LoadAll")]
        public List<VMAtrrbute> LoadAll()
       {
            return attrubService.loadall();
        } 
    }
}
