using Microsoft.AspNetCore.Identity;

namespace Vue.Models
{
    public class Role : IdentityRole<string>
    {
        public Role() { }

        public Role(string name)
        {
            Name = name;
        }
    }
}
