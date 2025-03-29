using AutoMapper;
using webapi.Infrastructures.DTOs;
using webapi.Infrastructures.Entities;

namespace webapi.Core.Mappings;

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
