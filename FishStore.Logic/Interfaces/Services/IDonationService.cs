using FishStore.Logic.DtoModels.Filters;
using FishStore.Storage.Database;
using FishStore.Storage.Models;

namespace FishStore.Logic.Interfaces.Services
{
    public interface IDonationService
    {
        IQueryable<Donation> GetCenterQueryble(DataContext dataContext, DonationFilterDto filter, bool asNoTracking);
    }
}
