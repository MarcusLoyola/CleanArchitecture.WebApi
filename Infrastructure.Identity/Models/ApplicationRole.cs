using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Models
{
    public class ApplicationRole : IdentityRole<int>
    {
        public ApplicationRole()
        {

        }

        public ApplicationRole(string roleName)
            : base(roleName)
        {

        }
    }

}
