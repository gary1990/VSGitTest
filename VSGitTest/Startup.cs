using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSGitTest.Startup))]
namespace VSGitTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
