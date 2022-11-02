using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crud_server.Services.InterfaceServices;
using Microsoft.AspNetCore.Mvc;

namespace crud_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _department;

        public DepartmentController(IDepartmentService department)
        {
            _department = department;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _department.GetAll();

            return Ok(departments);
        }
    }
}