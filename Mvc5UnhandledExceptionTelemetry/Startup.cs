using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5UnhandledExceptionTelemetry.Startup))]
namespace Mvc5UnhandledExceptionTelemetry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
