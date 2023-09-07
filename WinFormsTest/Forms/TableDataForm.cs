using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTest.Data;
using WinFormsTest.Models;
using WinFormsTest.Models.DTO;

namespace WinFormsTest.Forms;

public partial class TableDataForm : Form
{
	private ApplicationDbContext _context;

	public TableDataForm(ApplicationDbContext context)
	{
		InitializeComponent();
		_context = context;
		FormBorderStyle = FormBorderStyle.None;
		ControlBox = false;
		MaximizeBox = false;
		MinimizeBox = false;
		InitializeTableData();
	}

	private void InitializeTableData()
	{
		var data = from table in _context.Table
				   join tClub in _context.TableClub
				   on table.Id equals tClub.TableId
				   select new
				   {
					   tClub.ClubId,
					   tClub.ClubPoints,
					   table.Season
				   };

		var newData = data.Select(x =>
			new TableDataDTO
			{
				CityName = _context.Club.First(c => c.Id == x.ClubId).City,
				ClubName = _context.Club.First(c => c.Id == x.ClubId).Name,
				Points = x.ClubPoints,
				Season = x.Season
			}).ToList();

		
	}


	private void SetTableDataOnSeason()
	{
		var data = from table in _context.Table
				   join tClub in _context.TableClub
				   on table.Id equals tClub.TableId
				   // where season equals ...
				   select new
				   {
					   tClub.ClubId,
					   tClub.ClubPoints,
					   table.Season
				   };

		var newData = data.Select(x =>
			new TableDataDTO
			{
				CityName = _context.Club.First(c => c.Id == x.ClubId).City,
				ClubName = _context.Club.First(c => c.Id == x.ClubId).Name,
				Points = x.ClubPoints,
				Season = x.Season
			}).ToList();
	}
}
