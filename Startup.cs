using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LC_01.Startup))]
namespace LC_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
