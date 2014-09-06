using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCExerciseTry1.Startup))]
namespace MVCExerciseTry1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
