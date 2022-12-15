using System.ComponentModel.DataAnnotations;

namespace _278Project.Models;
public class RegisterViewModel
{
    [Required(ErrorMessage = "Please enter a username.")]
    public string? Username { get; set; }
    [Required(ErrorMessage = "Please enter a password.")]
    [Compare("ConfirmPassword")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
    [Required(ErrorMessage = "Please confirm your password.")]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    public string? ConfirmPassword { get; set; }
    [Required(ErrorMessage = "Please enter a valid email.")]
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }


}