using CRUDWithEntityHW.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDWithEntityHW.Data
{
    public class AdminDbContext:DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options)
            :base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }

    }
}
