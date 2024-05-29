using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FishStore.Storage.Models
{
    public class Donation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid IsnNode { get; set; }

        [Required, MaxLength(255)]
        [Range(1, double.MaxValue, ErrorMessage = "Пожалуйста, введите сумму больше 0")]
        public string Amount { get; set; }
        public Guid UserID { get; set; }
    }
}
