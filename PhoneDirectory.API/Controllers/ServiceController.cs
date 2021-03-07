using Microsoft.AspNetCore.Mvc;
using PhoneDirectory.Business.Services;

namespace PhoneDirectory.API.Controllers
{
    [ApiController]
    public class ServiceController<T> : ControllerBase where T : IService
    {
        protected T Service { get; set; }
        public ServiceController(T _service)
        {
            Service = _service;
        }
    }
}
