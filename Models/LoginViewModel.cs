using System.ComponentModel.DataAnnotations;
namespace _278Project.Models;
public class LoginViewModel
{
    [Required(ErrorMessage = "Please enter your username.")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Please enter your password.")]
    [StringLength(255)]
    public string? Password { get; set; }
    public string? ReturnUrl { get; set; }
    public bool RememberMe { get; set; }
}