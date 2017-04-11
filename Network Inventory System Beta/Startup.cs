using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Network_Inventory_System_Beta.Startup))]
namespace Network_Inventory_System_Beta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
