using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Models;
using Microsoft.EntityFrameworkCore;

namespace crud_server.Data
{
    public class ContextDatabase : DbContext
    {
        public ContextDatabase(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee>  Employees { get; set; }
        public DbSet<Department>  Departments { get; set; }
    }
}