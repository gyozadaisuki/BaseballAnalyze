using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BaseballAnalyze.Startup))]
namespace BaseballAnalyze
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
