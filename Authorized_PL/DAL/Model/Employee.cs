using Microsoft.AspNet.Identity.EntityFramework;

namespace DAL.Model
{
    public class Employee : IdentityUser 
    {
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
