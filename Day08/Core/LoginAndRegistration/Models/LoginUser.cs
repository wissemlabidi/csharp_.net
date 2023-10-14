#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // New import for ****
namespace LoginAndRegistration.Models;

public class LoginUser
{

    // Email
    [Required(ErrorMessage = "Please enter your email.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email.")]
    [Display(Name = "Email")]
    public string LoginEmail { get; set; }

    // Password
    [Required(ErrorMessage = "Please enter your password.")]
    [DataType(DataType.Password)] // useful
    [MinLength(8, ErrorMessage = "Please enter a valid Password .")]
    [Display(Name = "Password")]
    public string LoginPassword { get; set; }
}