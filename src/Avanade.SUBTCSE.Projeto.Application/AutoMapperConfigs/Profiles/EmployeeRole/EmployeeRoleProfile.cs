using AutoMapper;
using Avanade.SUBTCSE.Projeto.Application.Dtos.EmployeeRole;

namespace Avanade.SUBTCSE.Projeto.Application.AutoMapperConfigs.Profiles.EmployeeRole
{
    public class EmployeeRoleProfile : Profile
    {
        public EmployeeRoleProfile()
        {
            MapFromDomainToDto();
            MapFromDtoToDomain();
                        
        }

        public void MapFromDtoToDomain()
        {
            CreateMap<EmployeeRoleDto, Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole>()
                .ForCtorParam("roleName", opt => opt.MapFrom(src => src.Role));
        }

        public void MapFromDomainToDto()
        {
            CreateMap<Avanade.SUBTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities.EmployeeRole, EmployeeRoleDto>()
                .ForMember(target => target.Id, src => src.MapFrom(src => src.Id))
                .ForMember(target => target.Role, src => src.MapFrom(src => src.RoleName))
                .ForAllOtherMembers(option => option.Ignore());
        }
    }
}
