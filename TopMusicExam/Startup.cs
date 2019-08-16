using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopMusicExam.Startup))]
namespace TopMusicExam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
