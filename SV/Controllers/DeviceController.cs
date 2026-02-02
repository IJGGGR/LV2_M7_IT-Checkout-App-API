using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SV.Models;
using SV.Services;

namespace SV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController(IDeviceService svc) : ControllerBase
    {
        private readonly IDeviceService _svc = svc;

        [HttpPost("Add")]
        public Device Add(Device newObj)
        {
            return _svc.Add(newObj);
        }

        [HttpGet("GetAll")]
        public List<Device> GetAll()
        {
            return _svc.GetAll();
        }

        [HttpGet("GetAllAvailable")]
        public List<Device> GetAllAvailable()
        {
            return _svc.GetAllAvailable();
        }

        [HttpGet("GetById/{id}")]
        public Device? GetById(int id)
        {
            return _svc.GetById(id);
        }

        [HttpPut("Update/{id}")]
        public Device? Update(int id, Device modObj)
        {
            return _svc.Update(id, modObj);
        }

        [HttpDelete("Delete/{id}")]
        public bool Delete(int id)
        {
            return _svc.Delete(id);
        }
    }
}
