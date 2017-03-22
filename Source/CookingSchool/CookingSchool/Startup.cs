using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CookingSchool.Startup))]
namespace CookingSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
