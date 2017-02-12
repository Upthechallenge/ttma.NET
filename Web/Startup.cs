using Microsoft.Owin;
using Owin;
using System.Security.Claims;
using System.Web.Helpers;

[assembly: OwinStartupAttribute(typeof(Web.Startup))]
namespace Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           ConfigureAuth(app);
            app.MapSignalR();
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.Email;

        }
    }
}
