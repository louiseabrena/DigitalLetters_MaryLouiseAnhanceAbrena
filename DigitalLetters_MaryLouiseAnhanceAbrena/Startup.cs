using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DigitalLetters_MaryLouiseAnhanceAbrena.Startup))]
namespace DigitalLetters_MaryLouiseAnhanceAbrena
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
