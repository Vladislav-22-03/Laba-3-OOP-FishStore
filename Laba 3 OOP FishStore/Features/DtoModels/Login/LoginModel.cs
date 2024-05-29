using System.ComponentModel.DataAnnotations;

namespace Laba_3_OOP_FishStore.Features.DtoModels.Login
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string? Mail { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
