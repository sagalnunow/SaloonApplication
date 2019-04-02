using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaloonApplication.Startup))]
namespace SaloonApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
