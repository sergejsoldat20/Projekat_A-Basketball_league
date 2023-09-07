using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTest.Models.DTO;

public class TableDataDTO
{
	public string ClubName { get; set; } = string.Empty;
	public string CityName { get; set; } = string.Empty;
	public int Points { get; set; }
	public string Season { get; set; } = string.Empty;
}
