using Avanade.SUBTCSE.Projeto.Data.Base;
using Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;

namespace Avanade.SUBTCSE.Projeto.Data.EmployeeRole
{
    public class EmployeeRoleRepository : BaseRepository<Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, string>, IEmployeeRoleRepository
    {
    }
}
