using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookManagerr.Startup))]
namespace BookManagerr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
