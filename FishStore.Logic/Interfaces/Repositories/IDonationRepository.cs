using FishStore.Storage.Database;
using FishStore.Storage.Models;

namespace FishStore.Logic.Interfaces.Repositories
{
    public interface IDonationRepository
    {
        Donation Create(DataContext dataContext, Donation donation);
    }
}
