
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
    public class BrandController : ControllerBase
    {
        private readonly IBrandsService brandsService;
        public BrandController(IBrandsService _IBrandsService)
        {
            brandsService = _IBrandsService;

        }
        [HttpPost]
        [Route("insert")]

        public void Insert(Brands brands)
        {
           brandsService.Insert(brands);
        }

        [HttpGet]
        [Route("LoadAll")]
        public List<Brands> LoadAll()
        {
          //return  brandsService.loadAll();
            var x= brandsService.loadAll();
             return x;
        }
        [HttpGet]
        [Route("loadbyname")]

        public List<Brands> loadbyname(string name)
        {
            return brandsService.loadbyname(name);
        }

        [HttpGet]
        [Route("delete")]

        public void Delet(int id)
        {
            brandsService.dellet(id);
        }

        [HttpPost]
        [Route("Update")]

        public void Update(Brands brands)
        {
            brandsService.Update(brands);
        }
        [HttpGet]
        [Route("Edit")]
        public Brands Edit(int id)
        {
           return brandsService.edit(id);
        }
    
    }
}
