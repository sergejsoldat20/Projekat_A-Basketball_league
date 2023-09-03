using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Options;

public class AppOptions
{

	public const string SectionName = "Data";
	public string ConnectionString { get; set; } = String.Empty;
}
