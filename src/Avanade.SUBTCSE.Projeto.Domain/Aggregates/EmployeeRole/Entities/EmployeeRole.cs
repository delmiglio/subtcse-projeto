namespace Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole : BaseEntity<string>
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
        public string RoleName { get; init; }
    }
}
