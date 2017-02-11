using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsharpHomeTest.Startup))]
namespace CsharpHomeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
