using Artists.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Artists.DAL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private IConfiguration _configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            var connString = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ArtistsDbContext>(options =>
                options.UseSqlServer(connString));
        }
    }
}
