using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SV.Models;

namespace SV.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly List<Device> _list =
        [
            new() { Id = 1, Name = "Dell", Type = "Laptop", SerialNumber = "SN-0123", IsCheckedOut = true  },
            new() { Id = 2, Name = "iPad", Type = "Tablet", SerialNumber = "SN-4567", IsCheckedOut = true  },
            new() { Id = 3, Name = "Dell", Type = "Laptop", SerialNumber = "SN-89AB", IsCheckedOut = false },
            new() { Id = 4, Name = "Acer", Type = "Laptop", SerialNumber = "SN-CDEF", IsCheckedOut = false },
        ];

        public Device Add(Device newObj)
        {
            newObj.Id = _list.Count == 0 ? 1 : _list.Max(o => o.Id) + 1;

            _list.Add(newObj);

            return newObj;
        }

        public bool Delete(int id)
        {
            var device = _list.FirstOrDefault(o => o.Id == id);

            if (device == null) return false;

            _list.Remove(device);

            return true;
        }

        public Device? GetById(int id)
        {
            return _list.FirstOrDefault(o => o.Id == id);
        }

        public List<Device> GetAll()
        {
            return _list;
        }

        public List<Device> GetAllAvailable()
        {
            return [.. _list.Where(o => o.IsCheckedOut == false)];
        }

        public Device? Update(int id, Device modObj)
        {
            var oldObj = _list.FirstOrDefault(o => o.Id == id);

            if (oldObj == null) return null;

            oldObj.Name = modObj.Name;
            oldObj.Type = modObj.Type;
            oldObj.SerialNumber = modObj.SerialNumber;
            oldObj.IsCheckedOut = modObj.IsCheckedOut;

            return oldObj;
        }
    }
}
