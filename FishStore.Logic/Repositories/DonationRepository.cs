using FishStore.Logic.Interfaces.Repositories;
using FishStore.Storage.Database;
using FishStore.Storage.Models;

namespace FishStore.Logic.Repositories
{
    public class DonationRepository : IDonationRepository
    {
        public Donation Create(DataContext dataContext, Donation donation)
        {
            //user.IsnNode = Guid.NewGuid();
            dataContext.Donations.Add(donation);

            return donation;
        }
    }
}
