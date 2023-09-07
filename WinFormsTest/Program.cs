using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinFormsTest.Data;


namespace WinFormsTest;


internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        string connectionString = "Server=localhost;Port=5432;Database=hci_db;User Id=postgres;Password=adm1n;Pooling=true";
		// To customize application configuration such as set high DPI settings or default font,
		// see https://aka.ms/applicationconfiguration.
		ApplicationConfiguration.Initialize();

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<ApplicationDbContext>(
                    options => options.UseNpgsql(connectionString));
            }).Build(); // Remove title bar, borders, and buttons
		


		using (var serviceScope = host.Services.CreateScope())
        {
            var serviceProvider = serviceScope.ServiceProvider;
            var dbContext = serviceProvider.GetRequiredService <ApplicationDbContext>();
			Application.Run(new LoginForm(dbContext));
		}
	}
}