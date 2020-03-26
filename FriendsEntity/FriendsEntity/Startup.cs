using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendsEntity.Startup))]
namespace FriendsEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
