using FishStore.Logic.DtoModels.Filters;
using FishStore.Storage.Models;
using Laba_3_OOP_FishStore.Features.DtoModels.User;

namespace Laba_3_OOP_FishStore.Features.Interfaces.Managers
{
    public interface IUserManager

    {

        User GetUser(string mail, string password);
        void Create(EditUser editUser);

        Task<UserFilterDto> GetUserByMail(string mail);
    }
}
