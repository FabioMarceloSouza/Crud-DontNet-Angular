using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Models;
using crud_server.Dtos.EmployeeDtos;

namespace crud_server.Services.InterfaceServices
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAll();
        Task<Employee> Get(Guid id);
        Task<Employee> Create(EmployeeRequest employee);
        Task<Employee> Update(Employee employee);
        Task Delete(Guid id);

    }
}