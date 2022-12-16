using Microsoft.AspNetCore.Identity;
namespace _278Project.Models
{
    public class User : IdentityUser
    {

        public ICollection<Cart> Carts { get; set; } = null!;
        public ICollection<WishList> WishLists { get; set; } = null!;
    }
}
