using DAL.Model;
using Microsoft.AspNet.Identity.EntityFramework;


namespace DAL
{
    public class EmployeeContext :IdentityDbContext<Employee>
    {
        public EmployeeContext():base("DefaultConnection")
        {
           
        }


    }
}
