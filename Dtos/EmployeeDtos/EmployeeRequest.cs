using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud_server.Dtos.EmployeeDtos
{
    public class EmployeeRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        public Guid DepartmentId { get; set; }
    }
}