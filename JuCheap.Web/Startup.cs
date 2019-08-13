using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JuCheap.Web.Startup))]
namespace JuCheap.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           // ConfigureHangfire(app);
        }
    }
}
