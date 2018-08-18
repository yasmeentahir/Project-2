using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxInWebFormEg.Startup))]
namespace AjaxInWebFormEg
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
