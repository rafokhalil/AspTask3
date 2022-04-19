using CRUDWithEntityHW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithEntityHW.Services
{
     public interface IRepository
    {
        void Add(Admin item);
        void Delete(int id);
        void Update(Admin item);
        Admin Get(int id);
        IEnumerable<Admin> GetAll();
    }
}
