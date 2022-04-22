using InventoryBussnisesLogic.SpecificRepository;
using InventoryBussnisesLogicCore.SpecificRepository;
using InventoryDataAccessCore.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace InventoryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductesController : ControllerBase
    {
        private readonly IProductsService ProductsService;
        IConfiguration configuration;
        public ProductesController(IProductsService _ProductsService, IConfiguration _configuration)
        {
            ProductsService = _ProductsService;
            configuration = _configuration;

        }

        [HttpPost]
        [Route("UploadFile")]
        [AllowAnonymous]
        public IActionResult uploadFile()
        {
            try
            {
                IFormFile file = HttpContext.Request.Form.Files[0];

                string FilePath = Path.Combine(Directory.GetCurrentDirectory(), configuration["FilePath"], file.FileName);
                file.CopyTo(new FileStream(FilePath, FileMode.Create));
                return Ok(JsonSerializer.Serialize(file.FileName));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]  //Error
        public void Insert(Products p)
        {
            ProductsService.Insert(p);
        }

        [HttpGet]
        [Route("LoadAll")]
        public List<Products> LoadAll()
        {
            return ProductsService.LoadAll();
        }


        [HttpGet]
        [Route("delete")]

        public void Delet(int id)
        {
            ProductsService.dellet(id);
        }
        [HttpGet]
        [Route("fiinded")]

        public Products findes(int id)
        {
           return ProductsService.finded(id);
        }


    }
}
