using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsTest.Data;

namespace WinFormsTest.Dependency_Injection;

public static class DependencyInjection
{

	public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration) 
	{
		services.AddDbContext<ApplicationDbContext>(
			options => options.UseNpgsql(configuration.GetConnectionString("ConnectionString")));

		return services;
	}
}
