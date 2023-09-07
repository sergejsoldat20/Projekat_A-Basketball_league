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
using WinFormsTest.Models.Enums;

namespace WinFormsTest.Forms
{
	public partial class AddGamesForm : Form
	{
		private ApplicationDbContext _context;

		public AddGamesForm(ApplicationDbContext context)
		{
			InitializeComponent();
			_context = context;
			// Remove title bar, borders, and buttons
			FormBorderStyle = FormBorderStyle.None;
			ControlBox = false;
			MaximizeBox = false;
			MinimizeBox = false;
			InitializeAllComponents();
		}


		private void InitializeAllComponents()
		{
			var clubs = _context.Club.ToList();

			foreach (var club in clubs)
			{
				HomeClubs.Items.Add(club.Name);
				GuestClubs.Items.Add(club.Name);
			}

			foreach (var arena in Enums.ListOfArenas)
			{
				ArenaBox.Items.Add(arena);
			}

			foreach (var city in Enums.ListOfCities)
			{
				CityBox.Items.Add(city);
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void AddGameButton_Click(object sender, EventArgs e)
		{

			if (HomeClubs.SelectedIndex != -1 && GuestClubs.SelectedIndex != -1
				&& ArenaBox.SelectedIndex != -1 && CityBox.SelectedIndex != -1
				&& PointsGuest.Text != "" && PointsHome.Text != "")
			{
				var home = _context
				.Club
				.Where(x => x.Name == HomeClubs.SelectedItem.ToString())
				.First();

				var guest = _context
					.Club
					.Where(x => x.Name == GuestClubs.SelectedItem.ToString())
					.First();
				if (guest.Id != home.Id)
				{
					var game = new Game
					{
						GameTime = DateTime.UtcNow,
						GuestId = guest.Id,
						HomeId = home.Id,
						HomePoints = Int32.Parse(PointsHome.Text),
						GuestPoints = Int32.Parse(PointsGuest.Text),
						Arena = ArenaBox.SelectedItem.ToString(),
						City = CityBox.SelectedItem.ToString()
					};
					_context.Game.Add(game);
					_context.SaveChanges();
				}
				SetFieldsToNothing();
				MessageBox.Show("Success!");
				Refresh();
			}
			else
			{
				MessageBox.Show("Error");
			}
		}

		private void SetFieldsToNothing()
		{
			ArenaBox.SelectedIndex = -1;
			CityBox.SelectedIndex = -1;
			GuestClubs.SelectedIndex = -1;
			HomeClubs.SelectedIndex = -1;
			PointsGuest.Text = String.Empty;
			PointsHome.Text = String.Empty;
		}
	}
}
