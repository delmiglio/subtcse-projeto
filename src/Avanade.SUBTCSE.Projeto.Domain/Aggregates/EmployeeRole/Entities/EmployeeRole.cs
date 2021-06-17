using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole
    {

        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }

        public EmployeeRole(string id, string roleName) : this(id)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; init; }
        public string RoleName { get; init; }
    }
}
