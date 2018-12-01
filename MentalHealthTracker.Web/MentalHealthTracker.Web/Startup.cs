using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MentalHealthTracker.Web.Startup))]
namespace MentalHealthTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
