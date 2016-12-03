using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookApi.Startup))]
namespace BookApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
