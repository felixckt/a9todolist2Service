using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(a9todolist2Service.Startup))]

namespace a9todolist2Service
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}