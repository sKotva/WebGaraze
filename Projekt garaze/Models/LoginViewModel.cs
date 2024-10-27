namespace Projekt_garaze.Models;
using System.ComponentModel.DataAnnotations;



public class LoginViewModel
{
    [Required(ErrorMessage = "Vyplňte emailovou adresu")]
    [EmailAddress(ErrorMessage = "Neplatná emailova adresa")]
    [Display(Name = "Email")]
    public string Email { get; set; } = " ";

    [Required(ErrorMessage = "Vyplňte heslo")]
    [DataType(DataType.Password)]
    [Display(Name = "Heslo")]
    public string Password { get; set; } = " ";

    [Display(Name = "Pamatuj si mě")]
    public bool RememberMe { get; set; }
}
