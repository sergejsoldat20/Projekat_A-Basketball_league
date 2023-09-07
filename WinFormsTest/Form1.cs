using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTest.Data;
using WinFormsTest.Models;
using WinFormsTest.Forms;
using System.Net.Http.Headers;
using WinFormsTest.Models.Enums;

namespace WinFormsTest;

public partial class Form1 : Form
{
	public static Account account = new Account();

	private ResourceManager resourceManager;
	private PlayersForm playersForm;
	private Form activeForm;
	private string Role;
	private string SelectedLanguage = "en-US";

	private ApplicationDbContext _context;

	public Form1(ApplicationDbContext context, string role)
	{
		_context = context;
		Role = role;

		InitializeComponent();
		LanguagesBox.Items.Add("en");
		LanguagesBox.Items.Add("sr");
		// default language 
		SetLanguage();

		// authorization by role
		Authorization();
	}

	private void Authorization()
	{
		if (Role.Equals(Enums.User))
		{
			AddNewAccountButton.Visible = false;
			AddNewGameButton.Visible = false;
			AddNewPlayerButton.Visible = false;
		}
	}

	private void OpenChildForm(Form childForm, object btnSender)
	{
		if (activeForm != null)
		{
			activeForm.Close();
		}
		activeForm = childForm;
		childForm.TopLevel = false;
		childForm.Parent = ParentPanel;
		childForm.Dock = DockStyle.Fill;
		childForm.Show();
	}

	private void Form1_Load(object sender, EventArgs e)
	{

	}
	// TODO: to be translated 
	private void TableButton_Click(object sender, EventArgs e)
	{
		Form tableForm = new Forms.TableForm(_context);
		UpdateFormLanguage(tableForm);
		OpenChildForm(tableForm, e);
	}
	// TODO: to be translated 
	private void PlayersButton_Click(object sender, EventArgs e)
	{
		Form players = new Forms.PlayersForm(_context);
		UpdateFormLanguage(players);
		OpenChildForm(players, e);
	}

	private void ClubsButton_Click(object sender, EventArgs e)
	{
	}

	private void basketballPlayersControl1_Load(object sender, EventArgs e)
	{

	}


	private void SetLanguage()
	{
		CultureInfo cultureInfo = CultureInfo.GetCultureInfo(SelectedLanguage);
		resourceManager = new ResourceManager("WinFormsTest.Properties.Resources", typeof(Form1).Assembly);

		MainHeader.Text = resourceManager.GetString(MainHeader.Name, cultureInfo);
		PlayersButton.Text = resourceManager.GetString(PlayersButton.Name, cultureInfo);
		TableButton.Text = resourceManager.GetString(TableButton.Name, cultureInfo);
		GamesButton.Text = resourceManager.GetString(GamesButton.Name, cultureInfo);
		AddNewAccountButton.Text = resourceManager.GetString(AddNewAccountButton.Name, cultureInfo);
		AddNewGameButton.Text = resourceManager.GetString(AddNewGameButton.Name, cultureInfo);
		AddNewPlayerButton.Text = resourceManager.GetString(AddNewPlayerButton.Name, cultureInfo);
		ChangeLanguageButton.Text = resourceManager.GetString(ChangeLanguageButton.Name, cultureInfo);

		System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
		System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
	}

	private void UpdateFormLanguage(Form form)
	{
		CultureInfo cultureInfo = CultureInfo.GetCultureInfo(SelectedLanguage);
		resourceManager = new ResourceManager("WinFormsTest.Properties.Resources", typeof(Form1).Assembly);

		foreach (Control control in form.Controls)
		{
			if (control is Label label)
			{
				label.Text = resourceManager.GetString(label.Name, cultureInfo);
				//label.AutoSize = false;
				//label.TextAlign = ContentAlignment.MiddleRight;
				//label.Anchor = AnchorStyles.Right;
			}
			else if (control is Button button)
			{
				button.Text = resourceManager.GetString(button.Name, cultureInfo);
			}
			else if (control is DataGridView gridView)
			{
				foreach (DataGridViewColumn column in gridView.Columns)
				{
					if (column is DataGridViewTextBoxColumn textColumn)
					{
						// You can use the column's Name property as the key to retrieve the localized text
						string columnName = resourceManager.GetString(column.Name, cultureInfo);

						// Update the column header text
						textColumn.HeaderText = columnName;
					}
					// Add other column types as needed (e.g., DataGridViewButtonColumn, DataGridViewCheckBoxColumn, etc.)
				}
			}
		}

		// Change the current culture for formatting
		System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
		System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
	}

	private void AddPlayerButton_Click(object sender, EventArgs e)
	{
		Form addPlayerForm = new Forms.AddPlayerForm(_context);
		UpdateFormLanguage(addPlayerForm);
		OpenChildForm(addPlayerForm, e);
	}

	private void AddGameButton_Click(object sender, EventArgs e)
	{
		Form addGamesForm = new Forms.AddGamesForm(_context);
		UpdateFormLanguage(addGamesForm);
		OpenChildForm(addGamesForm, e);
	}

	// TODO: to be translated 
	private void GamesButton_Click(object sender, EventArgs e)
	{
		Form showGamesForm = new Forms.ShowGamesForm(_context);
		UpdateFormLanguage(showGamesForm);
		OpenChildForm(showGamesForm, e);
	}

	private void AddAccountButton_Click(object sender, EventArgs e)
	{
		Form addAccountForm = new Forms.AddUserForm(_context);
		UpdateFormLanguage(addAccountForm);
		OpenChildForm(addAccountForm, e);
	}

	private void ChangeLanguageButton_Click(object sender, EventArgs e)
	{
		if (LanguagesBox.SelectedIndex != -1 && activeForm != null)
		{
			var language = LanguagesBox.SelectedItem.ToString();

			if (language.Equals("en"))
			{
				SelectedLanguage = "en-US";
				UpdateFormLanguage(activeForm);

			}
			else
			{
				SelectedLanguage = "ru-RU";
				UpdateFormLanguage(activeForm);
			}
		}
		if (LanguagesBox.SelectedIndex != -1)
		{
			var language = LanguagesBox.SelectedItem.ToString();

			if (language.Equals("en"))
			{
				SelectedLanguage = "en-US";
				SetLanguage();
			}
			else 
			{
				SelectedLanguage = "ru-RU";
				SetLanguage();
			}
		}
	}
}
