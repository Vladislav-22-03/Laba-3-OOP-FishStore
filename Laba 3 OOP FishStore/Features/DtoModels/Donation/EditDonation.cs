using System.ComponentModel.DataAnnotations;

namespace Laba_3_OOP_FishStore.Features.DtoModels.Donation
{
    public class EditDonation
    {
        public Guid? IsnNode { get; set; }

        [Required, MaxLength(255)]
        public string? Amount { get; set; }

        public Guid UserID { get; set; }

    }
}
