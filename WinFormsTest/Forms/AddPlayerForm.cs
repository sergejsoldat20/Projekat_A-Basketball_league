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

namespace WinFormsTest.Forms;

public partial class AddPlayerForm : Form
{
	private ApplicationDbContext _context;
	private const string ErrorText = "FieldsError";
	private const string SuccessText = "Success";
	public AddPlayerForm(ApplicationDbContext context)
	{
		InitializeComponent();
		_context = context;
		// Remove title bar, borders, and buttons
		FormBorderStyle = FormBorderStyle.None;
		ControlBox = false;
		MaximizeBox = false;
		MinimizeBox = false;
		InitializeComponentBoxes();
	}

	private void InitializeComponentBoxes()
	{
		var clubs = _context.Club.ToList();
		foreach (var club in clubs)
		{
			// add clubs to clubs box
			ClubsBox.Items.Add(club.Name);
		}
		PositionsBox.Items.Add("C");
		PositionsBox.Items.Add("PF");
		PositionsBox.Items.Add("SF");
		PositionsBox.Items.Add("SG");
		PositionsBox.Items.Add("PG");
	}

	private void AddPlayerButton_Click(object sender, EventArgs e)
	{
		var club = _context
			.Club
			.Where(x => x.Name == ClubsBox.SelectedItem.ToString())
			.First();

		if (PositionsBox.SelectedIndex != -1 ||
			!string.IsNullOrWhiteSpace(NameField.Text) ||
			ClubsBox.SelectedIndex != -1 ||
			!string.IsNullOrWhiteSpace(DressNumberField.Text))
		{
			var player = new BasketballPlayer
			{
				Name = NameField.Text,
				DressNumber = DressNumberField.Text,
				Position = PositionsBox.SelectedIndex.ToString(),
				ClubId = club.Id,
			};

			_context.BasketballPlayer.Add(player);
			_context.SaveChanges();

			PositionsBox.SelectedIndex = -1;
			ClubsBox.SelectedIndex = -1;
			NameField.Text = string.Empty;
			DressNumberField.Text = string.Empty;
			MessageBox.Show(SuccessText);
		}
		else
		{
			MessageBox.Show(ErrorText);
		}
	}

	private void PlayerNameLabel_Click(object sender, EventArgs e)
	{

	}

	private void DressNumberLabel_Click(object sender, EventArgs e)
	{

	}
}
