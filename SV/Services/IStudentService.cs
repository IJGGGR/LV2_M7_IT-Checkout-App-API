using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SV.Models;

namespace SV.Services
{
    public interface IStudentService
    {
        Student Add(Student newObj);
        List<Student> GetAll();
        Student? GetById(int id);
        Student? Update(int id, Student modObj);
        bool Delete(int id);
    }
}
