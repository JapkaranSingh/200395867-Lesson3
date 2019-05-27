using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200395867_Lesson3.Startup))]
namespace _200395867_Lesson3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
