using EmployeeAccounting.Database;
using EmployeeAccounting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeAccounting
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<DivisionDirectory>()
                    .AddScoped<EmployeeDirectory>()
                    .AddDbContext<DirectoriesContext>(options =>
                        options.UseNpgsql("Host=localhost; Database=postgres; Username=postgres; Password=admin; Include Error Detail=True"))
                    .AddScoped<MainForm>();
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Form mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }
    }
}