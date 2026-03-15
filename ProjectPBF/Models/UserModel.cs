using Microsoft.AspNetCore.Identity;

namespace ProjectPBF.Models
{
    public class UserModel : IdentityUser<int>
    {
        public string Nick { get; set; }
        public string? AvatarUrl { get; set; }
    }
}