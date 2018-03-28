using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingGround_Proj2.Startup))]
namespace CodingGround_Proj2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
