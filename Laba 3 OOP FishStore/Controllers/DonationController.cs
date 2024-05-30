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
        public async Task<ActionResult> Success()
        {
            return View();
        }


    }
}