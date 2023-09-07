using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Globalization;

namespace WinFormsTest.Managers;

public static class GlobalResourceManager
{
	private static readonly ResourceManager  _resourceManager = 
		new ResourceManager("WinFormsTest.Properties.Resources", typeof(GlobalResourceManager).Assembly);

	public static string GetLabel(string resourceName, string cultureCode)
	{

		CultureInfo cultureInfo = CultureInfo.GetCultureInfo(cultureCode);
		return _resourceManager.GetString(resourceName, cultureInfo);
	}


}
