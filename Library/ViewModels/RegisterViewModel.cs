using System.ComponentModel.DataAnnotations;

namespace Library.ViewModels
{
  public class RegisterViewModel
  {
    [Display(Name = "UserName")]
    [Required(ErrorMessage = "User name is required")]
    public string UserName { get; set; }

    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First name is required")]
    public string PatronFirst { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last name is required")]
    public string PatronLast { get; set; }

    [Required(ErrorMessage = "Email address is required")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Confirm email")]
    [Required(ErrorMessage = "Email address is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
    public string ConfirmEmail { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Required(ErrorMessage = "Password is required")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }


  }
}