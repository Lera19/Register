using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BL.Managers
{
    public class DefaultRoleManager : RoleManager<IdentityRole>
    {
        public DefaultRoleManager(IRoleStore<IdentityRole, string> store) : base(store)
        { }
    }

}
