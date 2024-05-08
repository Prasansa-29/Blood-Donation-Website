using Microsoft.AspNetCore.Identity;

namespace BloodDonation.Data
{
    public class AppUsers: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Hospital { get; set; }

        public string Position { get; set; }
    }
}
