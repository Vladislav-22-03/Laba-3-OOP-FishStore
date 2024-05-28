using AutoMapper;
using FishStore.Storage.Models;
using Laba_3_OOP_FishStore.Features.DtoModels.Center;

namespace Laba_3_OOP_FishStore.Features.Mappers
{
    public class CenterMapper : Profile
    {
        public CenterMapper()
        {
            CreateMap<EditCenter, Center>().ReverseMap();
        }
    }
}
