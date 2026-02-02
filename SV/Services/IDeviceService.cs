using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SV.Models;

namespace SV.Services
{
    public interface IDeviceService
    {
        Device Add(Device newObj);
        List<Device> GetAll();
        List<Device> GetAllAvailable();
        Device? GetById(int id);
        Device? Update(int id, Device modObj);
        bool Delete(int id);
    }
}
