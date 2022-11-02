using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Data;
using crud_server.Dtos.EmployeeDtos;
using crud_server.Models;
using crud_server.Services.InterfaceServices;
using Microsoft.EntityFrameworkCore;

namespace crud_server.Services
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly ContextDatabase _context;

        public EmployeeServices(ContextDatabase context){
            _context = context;
        }
        public async Task<Employee> Create(EmployeeRequest employee)
        {
            var newEmployee = new Employee {
                Id = Guid.NewGuid(),
                Name = employee.Name,
                Email = employee.Email,
                Phone = employee.Phone,
                Salary = employee.Salary,
                DepartmentId = employee.DepartmentId
            };

            _context.Employees.Add(newEmployee);
            await _context.SaveChangesAsync();

            return newEmployee;
        }

        public async Task Delete(Guid id)
        {
            var employee = _context.Employees.Find(id);

            if(employee == null){
               throw new Exception("Employee not found!");
            }
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

           
        }


        public async Task<Employee> Get(Guid id)
        {
            var employee = await  _context.Employees
           .Include(e => e.Department)
           .FirstOrDefaultAsync(e => e.Id == id);

            if(employee == null){
               throw new Exception("Employee not found!");
            }

            return employee;
        }

        public async Task<List<Employee>> GetAll()
        {
            var employees = await _context.Employees
            .Include(e => e.Department)
            .ToListAsync();

            return employees;
        }

        public async Task<Employee> Update(Employee employee)
        {
            var getEmployee = await _context.Employees.FindAsync(employee.Id);

             if(getEmployee == null){
               throw new Exception("Employee not found!");
            }

            getEmployee.Name = employee.Name;
            getEmployee.Email = employee.Email;
            getEmployee.Phone = employee.Phone;
            getEmployee.Salary = employee.Salary;
            getEmployee.DepartmentId = employee.DepartmentId;
            await _context.SaveChangesAsync();
            return getEmployee;

        }
    }
}