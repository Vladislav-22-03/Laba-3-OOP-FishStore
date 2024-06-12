using Laba_3_OOP_FishStore.Features.DtoModels.Donation;
using Laba_3_OOP_FishStore.Features.Interfaces.Managers;
using Microsoft.AspNetCore.Mvc;

namespace Laba_3_OOP_FishStore.Controllers
{
    [Route("Donation")]
    public class DonationController : Controller
    {
        private readonly IDonationManager _donationManager;
        public DonationController(IDonationManager donationManager)
        {
            this._donationManager = donationManager;
        }

        [HttpGet, Route("Success")]
        public async Task<ActionResult> Success(Guid id)
        {
            return View(new EditDonation() { UserID = id });
        }

        [HttpPost(nameof(AddDonation), Name = nameof(AddDonation))]
        public async Task<ActionResult> AddDonation(EditDonation addDonation)
        {
            if (!ModelState.IsValid)
                return View(nameof(Success), addDonation);
            try
            {
                _donationManager.Create(addDonation);
                return View("Finall");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(nameof(AddDonation), addDonation);
            }
        }

    }
}