using Microsoft.EntityFrameworkCore;
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
using WinFormsTest.Models.DTO;

namespace WinFormsTest.Forms;

public partial class TableForm : Form
{
	private ApplicationDbContext _context;
	private const string ALL = "All";
	public TableForm(ApplicationDbContext context)
	{
		InitializeComponent();
		_context = context;
		FormBorderStyle = FormBorderStyle.None;
		ControlBox = false;
		MaximizeBox = false;
		MinimizeBox = false;
		InitializeTable();
	}

	private void InitializeTable()
	{
		var seasons = _context.Table.Select(x => x.Season).Distinct().ToList();
		seasons.Add(ALL);
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

		foreach (var row in newData)
		{
			TableData.Rows.Add(row.ClubName, row.CityName, row.Season, row.Points);
		}

		foreach (var season in seasons)
		{
			SeasonsBox.Items.Add(season);
		}
	}

	private void ChooseSeasonButton_Click(object sender, EventArgs e)
	{
		var season = SeasonsBox.SelectedItem.ToString();

		// if season is empty set all elements  
		if (!string.IsNullOrWhiteSpace(season) && season.Equals(ALL))
		{
			SeasonsBox.Items.Clear();
			TableData.Rows.Clear();
			InitializeTable();
		}
		else
		{
			// pick data selected by season
			var data = from table in _context.Table
					   join tClub in _context.TableClub
					   on table.Id equals tClub.TableId
					   where table.Season == season
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

			// clear table and add all rows
			TableData.Rows.Clear();

			foreach (var row in newData)
			{
				TableData.Rows.Add(row.ClubName, row.CityName, row.Season, row.Points);
			}
		}
	}
}
