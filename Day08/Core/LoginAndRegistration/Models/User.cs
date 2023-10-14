#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //New Import For ***
namespace LoginAndRegistration.Models;

public class User
{
    //User Id
    [Key]
    public int UserId { get; set; }
    //First Name
    [Required (ErrorMessage ="Please enter your First Name")]
    [MinLength(2, ErrorMessage ="Please enter a valid First Name")]
    [Display(Name = "First Name ")]
    public string FirstName { get; set; }

    //Last Name
    [Required (ErrorMessage ="Please enter your Last Name")]
    [MinLength(2, ErrorMessage ="Please enter a valid Last Name")]
    [Display(Name = "Last Name ")]
    public string LastName { get; set; }

    //Email
    [Required(ErrorMessage = "Please enter your email")]
    [EmailAddress(ErrorMessage ="Please enter a valid email")]
    public string Email { get; set; }

    //Password
    [Required(ErrorMessage = "Please enter your Password")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage ="Please enter a valid passeword")]
    public string Password { get; set; }

    //Confirm Password
    [NotMapped]
    [Required(ErrorMessage = "Please enter your Password")]
    [DataType(DataType.Password)]
    [Compare("Password",ErrorMessage ="Password must match")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }

    //Created At
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    //Apdated At
    public DateTime ApdatedAt { get; set; } = DateTime.Now;
}