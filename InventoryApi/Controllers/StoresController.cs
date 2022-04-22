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
    public class StoresController : ControllerBase
    {
        private readonly IStoresService storesService;
        public StoresController(IStoresService stores)
        {
            storesService = stores;

        }
        [HttpPost]
        public void Insert(Stores stores)
        {
            storesService.Insert(stores);
        }

        [HttpGet]
        [Route("LoadAll")]
        public List<Stores> LoadAll()
        
        {
            return storesService.LoadAll();
        }
        [HttpGet]
        [Route("loadbyname")]

        public List<Stores> loadbyname(string name)
        {
            return storesService.loadbyname(name);
        }

        [HttpGet]
        [Route("delete")]

        public void Delet(int id)
        {
            storesService.dellet(id);
        }

        [HttpPost]
        [Route("Update")]

        public void Update(Stores s)
        {
            storesService.Update(s);
        }
    }
}
