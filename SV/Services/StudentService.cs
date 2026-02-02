using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SV.Models;

namespace SV.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<Student> _list =
        [
            new() { Id = 1, FullName = "Isaias",  Email = "isaias@email.com",  DeviceCheckedOutId = 1 },
            new() { Id = 2, FullName = "Pallavi", Email = "pallavi@email.com", DeviceCheckedOutId = 2 },
        ];

        public Student Add(Student newObj)
        {
            newObj.Id = _list.Count == 0 ? 1 : _list.Max(o => o.Id) + 1;

            _list.Add(newObj);

            return newObj;
        }

        public bool Delete(int id)
        {
            var obj = _list.FirstOrDefault(o => o.Id == id);

            if (obj == null) return false;

            _list.Remove(obj);

            return true;
        }

        public Student? GetById(int id)
        {
            return _list.FirstOrDefault(o => o.Id == id);
        }

        public List<Student> GetAll()
        {
            return _list;
        }

        public Student? Update(int id, Student modObj)
        {
            var oldObj = _list.FirstOrDefault(o => o.Id == id);

            if (oldObj == null) return null;

            oldObj.FullName = modObj.FullName;
            oldObj.Email = modObj.Email;
            oldObj.DeviceCheckedOutId = modObj.DeviceCheckedOutId;

            return oldObj;
        }
    }
}
