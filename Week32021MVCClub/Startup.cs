using Microsoft.Owin;
using Owin;
using ActivityTracker;

[assembly: OwinStartupAttribute(typeof(Week32021MVCClub.Startup))]
namespace Week32021MVCClub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Activity.Track("Logging in as Authenticated User");
            ConfigureAuth(app);
        }
    }
}
