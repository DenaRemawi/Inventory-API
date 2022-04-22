
using InventoryBussnisesLogic.SpecificRepository;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _icategory)
        {
            categoryService = _icategory;

        }
        [HttpPost]
        public void Insert(Category category)
        {
           categoryService.Insert(category);
        }

        [HttpGet]
        [Route("delete")]

        public void Delet(int id)
        {
            categoryService.dellet(id);
        }

        [HttpGet]
        [Route("LoadAll")]
        public List<Category> LoadAll()
        {
            return categoryService.LoadAll();
        }
        [HttpGet]
        [Route("loadbyname")]

        public List<Category> loadbyname(string name)
        {
            return categoryService.loadbyname(name);
        }

        [HttpPost]
        [Route("Update")]

        public void Update(Category ca)
        {
           categoryService.Update(ca);
        }

    }
}
