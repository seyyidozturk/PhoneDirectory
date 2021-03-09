using Microsoft.AspNetCore.Mvc;
using PhoneDirectory.Business.Model;
using PhoneDirectory.Business.Repositories;
using PhoneDirectory.Business.Services;
using PhoneDirectory.Data.Entities;
using System;

namespace PhoneDirectory.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ServiceController<IPersonService>
    {
        public PersonController(IPersonService _service) : base(_service)
        {
        }

        [HttpGet]
        public ActionResult GetList()
        {
            var result = Service.GetAllPersons();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult GetById(Guid id)
        {
            var result = Service.GetPersonByIdWithCommunication(id);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Person person)
        {
            var result = Service.CreatePerson(person);
            return Ok(result);
        }

        [HttpPut]
        public ActionResult Update([FromBody] Person person)
        {
            var result = Service.UpdatePerson(person);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Save([FromBody] Person person)
        {
            Result result;
            if (person.Id!=Guid.Empty)
            {
                result = Service.UpdatePerson(person);
            }
            else
            {
                result = Service.CreatePerson(person);
            }
        
            return Ok(result);
        }


        [HttpPost]
        public ActionResult Delete(Guid id)
        {
            var result = Service.DeletePerson(id);
            return Ok(result);
        }
    }
}
