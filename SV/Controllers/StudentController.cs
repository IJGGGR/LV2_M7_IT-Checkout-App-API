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
    public class StudentController(IStudentService svc) : ControllerBase
    {
        private readonly IStudentService _svc = svc;

        [HttpPost("Add")]
        public Student Add(Student newObj)
        {
            return _svc.Add(newObj);
        }

        [HttpGet("GetAll")]
        public List<Student> GetAll()
        {
            return _svc.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public Student? GetById(int id)
        {
            return _svc.GetById(id);
        }

        [HttpPut("Update/{id}")]
        public Student? Update(int id, Student modObj)
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
