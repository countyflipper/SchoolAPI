using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>()
                    .ForMember(c => c.UserName,
                        opt => opt.MapFrom(x => string.Join(' ', x.Status, x.SystemRoleID)));
        }
    }
}