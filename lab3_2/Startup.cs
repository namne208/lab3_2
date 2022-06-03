using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab3_2.Startup))]
namespace lab3_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
