using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Options;

internal sealed class AppOptionsSetup : IConfigureOptions<AppOptions>
{
	private readonly IConfiguration _configuration;

	public AppOptionsSetup(IConfiguration configuration) => _configuration = configuration;
	// Configure appsettings
	public void Configure(AppOptions options) =>
		_configuration.GetSection(AppOptions.SectionName).Bind(options);
}
