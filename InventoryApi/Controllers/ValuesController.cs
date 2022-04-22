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
    public class ValuesController : ControllerBase
    {

        private readonly IAttrubuitValueService attrubuitValueServiceee;
        public ValuesController(IAttrubuitValueService Vaalue)
        {
            attrubuitValueServiceee = Vaalue;

        }

        [HttpPost]  //Error
        public void Insert(AttrubuitValue v)
        {
            attrubuitValueServiceee.Insert(v);
        }

        [HttpGet] //postman done
        [Route("delete")]

        public void Delet(int id)
        {
            attrubuitValueServiceee.dellet(id);
        }

        [HttpGet] //postman done
        [Route("LoadAll")]
        public List<AttrubuitValue> LoadAll(int id)
        {

            return attrubuitValueServiceee.Loadall(id);
        }
        [HttpGet]
        [Route("loadbyname")] //postman done

        public List<AttrubuitValue> loadbyname(string name)
        {
            return attrubuitValueServiceee.loadbyname(name);
        }
        [HttpPost]
        [Route("Update")] //Error
        public void update(AttrubuitValue attrubuitValue)
        {
            attrubuitValueServiceee.update(attrubuitValue);
        }

    }

       
   
}
