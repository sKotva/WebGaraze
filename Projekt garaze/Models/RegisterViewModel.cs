using System.ComponentModel.DataAnnotations;

namespace Projekt_garaze.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Vyplňte email")]
        [EmailAddress(ErrorMessage = "Neplatný email")]
        [Display(Name = "Email")]
        public string Email { get; set; } = " ";

        [Required(ErrorMessage = "Zadejte heslo")]
        [StringLength(100, ErrorMessage = "{0} musí mít delku alespoň {2} a nejvíce {1} znaku.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "¨Heslo")]
        public string Password { get; set; } = " ";

        [Required(ErrorMessage = "Potvrďte heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Potvrďte heslo")]
        [Compare(nameof(Password), ErrorMessage = "Zadaná hesla se musí shodovat.")]
        public string ConfirmPassword { get; set; } = " ";
    }
}
