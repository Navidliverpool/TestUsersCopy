using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using TestUsersCopy.Data.Repositories;
using TestUsersCopy.Models;

[assembly: OwinStartupAttribute(typeof(TestUsersCopy.Startup))]
namespace TestUsersCopy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        public void ConfigureServices(IServiceCollection services)
        {
        }

    }
}
