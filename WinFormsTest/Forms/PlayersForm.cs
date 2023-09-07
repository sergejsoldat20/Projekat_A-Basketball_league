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

public partial class PlayersForm : Form
{
	private ApplicationDbContext _context;
	public PlayersForm(ApplicationDbContext context)
	{
		InitializeComponent();
		_context = context;
		// Remove title bar, borders, and buttons
		FormBorderStyle = FormBorderStyle.None;
		ControlBox = false;
		MaximizeBox = false;
		MinimizeBox = false;
		InitializeTableData();
	}

	private void InitializeTableData()
	{
		var players = _context
			.BasketballPlayer.ToList();

		foreach (var player in players)
		{
			var clubName = _context
				.Club
				.Where(x => x.Id == player.ClubId)
				.Select(x => x.Name)
				.First();
			PlayersGridView.Rows.Add(player.Name, player.DressNumber,
				player.Position, clubName);
		}
	}
}
