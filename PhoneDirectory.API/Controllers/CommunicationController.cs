using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneDirectory.Business.Services;
using PhoneDirectory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneDirectory.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommunicationController : ServiceController<ICommunicationService>
    {
        public CommunicationController(ICommunicationService _service) : base(_service)
        {
        }

        [HttpPost]
        public ActionResult Save([FromBody] Communication communication)
        {
            var result = Service.CreateCommunication(communication);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var result = Service.DeleteCommunication(id);
            return Ok(result);
        }
    }
}
