using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUsersCopy.Startup))]
namespace TestUsersCopy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
