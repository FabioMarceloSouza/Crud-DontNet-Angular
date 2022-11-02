using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace crud_server.Models
{
    public class Employee
    {   
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public double Salary { get; set; }
        public Guid DepartmentId { get; set; }
        [JsonIgnore]
        public Department? Department { get; set; }
    }
}