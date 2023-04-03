using APIProject.Data;
using APIProject.Services;
using Microsoft.EntityFrameworkCore;

namespace APIProject
{
    public static class ServiceExtension
    {
        #region DATACONTEXT
        public static void ConfigureConnectionString(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddDbContext<AppDbContext>(op => op.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
        #endregion


        public static void ConfigureInterfaceAddrepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStudentServices, StudentServices>();
        }
    }

    
}
