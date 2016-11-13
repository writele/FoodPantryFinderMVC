using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodPantryFinderMVC.Startup))]
namespace FoodPantryFinderMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
