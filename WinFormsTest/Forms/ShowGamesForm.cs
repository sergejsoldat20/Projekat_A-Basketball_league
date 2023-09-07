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

namespace WinFormsTest.Forms;

public partial class ShowGamesForm : Form
{
	private ApplicationDbContext _context;
	public ShowGamesForm(ApplicationDbContext context)
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
		var games = _context.Game.ToList();

		foreach (var game in games)
		{
			var home = _context.Club.First(x => x.Id == game.HomeId);
			var guest = _context.Club.First(x => x.Id == game.GuestId);
			GamesGrid.Rows.Add(home.Name, guest.Name, game.City,
				game.Arena, game.HomePoints, game.GuestPoints, game.GameTime);
		}
	}
}
