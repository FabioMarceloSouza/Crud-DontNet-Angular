using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Data;
using crud_server.Dtos.EmployeeDtos;
using crud_server.Models;
using crud_server.Services.InterfaceServices;
using Microsoft.AspNetCore.Mvc;

namespace crud_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employee;

        public EmployeeController(IEmployeeService employee)
        {
            _employee = employee;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EmployeeRequest request)
        {
            var newEmployee =  await _employee.Create(request);

            return StatusCode(201, newEmployee);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _employee.GetAll();

            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var employee =  await _employee.Get(id);

            return Ok(employee);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Employee employee)
        {
            var newEmployee = await _employee.Update(employee);

            return Ok(newEmployee);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
           await _employee.Delete(id);

            return Ok();
        }
    }
}