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
    public class orderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public orderController(IOrderService _iorderservice)
        {
            orderService = _iorderservice;

        }
        [HttpPost]
        [Route("insert")]

        public void Insert(Order o)
        {
            orderService.Insert(o);
        }

        [HttpGet]
        [Route("LoadAll")]
        public List<Order> LoadAll()
        {
            var x = orderService.loadAll();
            return x;
        }
        [HttpGet]
        [Route("loadbyname")]

        public List<Order> loadbyname(string name)
        {
            return orderService.loadbyname(name);
        }

        [HttpGet]
        [Route("delete")]

        public void Delet(int id)
        {
            orderService.dellet(id);
        }

        [HttpPost]
        [Route("Update")]

        public void Update(Order o)
        {
            orderService.Update(o);
        }


    }
}

