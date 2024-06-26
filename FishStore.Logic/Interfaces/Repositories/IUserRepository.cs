﻿using FishStore.Storage.Database;
using FishStore.Storage.Models;

namespace FishStore.Logic.Interfaces.Repositories
{
    public interface IUserRepository
    {
        User Create(DataContext dataContext, User user);
        Task<User> GetByMail(DataContext context, string mail);

        //Center Update(DataContext dataContext, Center center);

        //void Delete(DataContext dataContext, Guid isnNode);

        //Center GetById(DataContext dataContext, Guid isnNode);
    }
}
