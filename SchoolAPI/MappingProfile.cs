using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace SchoolAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //-----------------------------------------------------------------
            CreateMap<User, UserDto>()
                    .ForMember(c => c.UserName,
                        opt => opt.MapFrom(x => string.Join(' ', x.Status, x.SystemRoleID)));

            CreateMap<UserForCreationDto, User>();
            CreateMap<UserForUpdateDto, User>();

            //-----------------------------------------------------------------
            CreateMap<CourseManagement, CourseManageDTO>()
                .ForMember(c => c.AssignmentTitle,
                    opt => opt.MapFrom(x => string.Join(' ', x.AssigmentID, x.AssignmentTitle)));

            CreateMap<CourseManageForCreationDto, CourseManagement>();
            CreateMap<CourseManageForUpdateDto, CourseManagement>();
            //-----------------------------------------------------------------

            CreateMap<Courses, CourseDto>()
                .ForMember(c => c.CourseName,
                 opt => opt.MapFrom(x => string.Join(' ', x.CourseName, x.Description)));

            CreateMap<CourseForCreationDto, Courses>();
            CreateMap<CourseForUpdateDto, Courses>();
            //-----------------------------------------------------------------
        }
    }
}