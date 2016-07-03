using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCFirstApplication.Startup))]
namespace MyMVCFirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
