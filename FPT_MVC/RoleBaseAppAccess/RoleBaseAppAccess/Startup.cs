using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoleBaseAppAccess.Startup))]
namespace RoleBaseAppAccess
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
