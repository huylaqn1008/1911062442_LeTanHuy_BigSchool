using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911062442_LeTanHuy_BigSchool.Startup))]
namespace _1911062442_LeTanHuy_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
