using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGitRepo2.Startup))]
namespace MyGitRepo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
