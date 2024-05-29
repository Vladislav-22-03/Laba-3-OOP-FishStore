using FishStore.Logic.DtoModels.Filters;
using FishStore.Logic.Interfaces.Services;
using FishStore.Storage.Database;
using FishStore.Storage.Models;
using Microsoft.EntityFrameworkCore;

namespace FishStore.Logic.Services
{
    public class DonationService : IDonationService
    {
        public IQueryable<Donation> GetCenterQueryble(DataContext dataContext, DonationFilterDto filter, bool asNoTracking)
        {
            IQueryable<Donation> query = dataContext.Donations;

            if (asNoTracking)
                query = query.AsNoTracking();

            if (!string.IsNullOrEmpty(filter.Amount))
                query = query.Where(x => x.Amount == filter.Amount);

            return query;
        }
    }
}
