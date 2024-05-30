using AutoMapper;
using FishStore.Logic.Interfaces.Repositories;
using FishStore.Logic.Interfaces.Services;
using FishStore.Storage.Database;
using FishStore.Storage.Models;
using Laba_3_OOP_FishStore.Features.DtoModels.Donation;
using Laba_3_OOP_FishStore.Features.Interfaces.Managers;

namespace Laba_3_OOP_FishStore.Features.Managers
{
    public class DonationManager : IDonationManager
    {
        private readonly IMapper _mapper;
        private readonly IDonationRepository _donationRepository;
        private readonly IDonationService _donationService;
        private readonly DataContext _dataContext;
        public DonationManager(IMapper mapper, IDonationRepository donationRepository, IDonationService donationService, DataContext dataContext)
        {
            _mapper = mapper;
            _donationRepository = donationRepository;
            _donationService = donationService;
            _dataContext = dataContext;
        }

        public void Create(EditDonation editDonation)
        {
            var donation = new Donation
            {
                IsnNode = editDonation.IsnNode ?? Guid.NewGuid(),
                Amount = editDonation.Amount,
                UserID = editDonation.UserID,
            };
            _donationRepository.Create(_dataContext, donation);

            _dataContext.SaveChanges();
        }
    }
}
