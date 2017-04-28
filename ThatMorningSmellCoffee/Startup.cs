using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThatMorningSmellCoffee.Startup))]
namespace ThatMorningSmellCoffee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
