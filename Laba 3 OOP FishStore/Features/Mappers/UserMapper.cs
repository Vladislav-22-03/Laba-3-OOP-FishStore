using AutoMapper;
using FishStore.Logic.DtoModels.Filters;
using FishStore.Storage.Models;
using Laba_3_OOP_FishStore.Features.DtoModels.User;

namespace Laba_3_OOP_FishStore.Features.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, EditUser>().ReverseMap();
            CreateMap<User, UserFilterDto>().ReverseMap();
        }
        
    }
}
 