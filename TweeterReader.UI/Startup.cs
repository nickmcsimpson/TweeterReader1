using Owin;
using log4net.Config;

namespace IdentitySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            XmlConfigurator.Configure();
            ConfigureAuth(app);
        }
    }
}
