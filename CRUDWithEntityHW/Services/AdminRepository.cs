using CRUDWithEntityHW.Data;
using CRUDWithEntityHW.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithEntityHW.Services
{
    public class AdminRepository : IRepository
    {

        private readonly AdminDbContext _context;

        public AdminRepository(AdminDbContext context)
        {
            _context = context;
        }

        public void Add(Admin item)
        {
            _context.Admins.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Admin Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public void Update(Admin item)
        {
            throw new NotImplementedException();
        }
    }
}
