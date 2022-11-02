using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace crud_server.Models
{
    public class Department
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}