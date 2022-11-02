using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Models;

namespace crud_server.Services.InterfaceServices
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAll();
        Task<Department> Get(Guid id);
        Task<Department> Create(Department employee);
        Task<Employee> Update(Department employee);
        void Delete(Guid id);
    }
}