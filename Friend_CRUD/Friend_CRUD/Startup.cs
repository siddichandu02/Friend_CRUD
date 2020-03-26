using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Friend_CRUD.Startup))]
namespace Friend_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
