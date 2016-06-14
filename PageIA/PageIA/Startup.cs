using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PageIA.Startup))]
namespace PageIA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
