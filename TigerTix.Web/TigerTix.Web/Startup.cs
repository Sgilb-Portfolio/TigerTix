using TigerTix.Web.Services;

namespace TigerTix.Web
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            // Other service configurations...

            services.AddScoped<ICartService, CartService>();

            // Other service configurations...
        }

        // Other methods...
    }
}
