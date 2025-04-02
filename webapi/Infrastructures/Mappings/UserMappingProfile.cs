using AutoMapper;
using Infrastructures.DTOs;
using Infrastructures.DTOs.User;
using Infrastructures.Entities;

namespace Infrastructures.Mappings;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap(typeof(User), typeof(ResultDto<>).MakeGenericType(typeof(User)));
        CreateMap<UserCreateRequest, User>();
        CreateMap<UserUpdateRequest, User>()
            .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
    }
}
