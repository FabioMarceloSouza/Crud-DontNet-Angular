using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Data;
using crud_server.Models;
using crud_server.Services.InterfaceServices;
using Microsoft.EntityFrameworkCore;

namespace crud_server.Services
{
    public class DepartmentServices : IDepartmentService
    {
        private readonly ContextDatabase _context;

        public DepartmentServices(ContextDatabase context)
        {
            _context = context;
        }

        public Task<Department> Create(Department employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Department> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAll()
        {
           var departments = await _context.Departments.ToListAsync();

           return departments;
        }

        public Task<Employee> Update(Department employee)
        {
            throw new NotImplementedException();
        }
    }
}