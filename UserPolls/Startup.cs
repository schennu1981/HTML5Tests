using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserPolls.Startup))]
namespace UserPolls
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
