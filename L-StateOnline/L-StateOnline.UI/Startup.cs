using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L_StateOnline.UI.Startup))]
namespace L_StateOnline.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
