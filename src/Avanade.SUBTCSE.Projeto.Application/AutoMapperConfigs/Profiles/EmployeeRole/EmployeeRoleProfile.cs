using AutoMapper;

namespace Avanade.SUBTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            CreateMap<Dtos.EmployeeRoleDto, Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Role));
        }
    }
}
