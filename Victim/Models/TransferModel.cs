using System.ComponentModel.DataAnnotations;

namespace Victim.Models
{
    public class TransferModel
    {
        [Required]
        [Display(Name = "Target account")]
        public string TargetAccount { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; }
    }
}