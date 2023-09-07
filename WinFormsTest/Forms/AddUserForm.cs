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
using WinFormsTest.Models;
using WinFormsTest.Models.Enums;

namespace WinFormsTest.Forms;

public partial class AddUserForm : Form
{
	private ApplicationDbContext _context;
	public AddUserForm(ApplicationDbContext context)
	{
		InitializeComponent();
		_context = context;
		// Remove title bar, borders, and buttons
		FormBorderStyle = FormBorderStyle.None;
		ControlBox = false;
		MaximizeBox = false;
		MinimizeBox = false;

		RolesBox.Items.Add(Enums.Admin);
		RolesBox.Items.Add(Enums.User);
	}

	private void ClearFields()
	{
		FirstNameField.Clear();
		LastNameField.Clear();
		PasswordBox.Clear();
		RolesBox.SelectedIndex = -1;
		UsernameField.Clear();

	}

	private void AddPlayerButton_Click(object sender, EventArgs e)
	{
		var firstName = FirstNameField.Text;
		var lastName = LastNameField.Text;
		var password = PasswordBox.Text;
		var username = UsernameField.Text;

		if (firstName != "" && lastName != "" && password != ""
			&& username != "" && RolesBox.SelectedIndex != -1)
		{
			var role = RolesBox.SelectedItem.ToString();
			var account = new Account
			{
				FirstName = firstName,
				LastName = lastName,
				Password = password,
				Username = username,
				Role = role
			};

			_context.Account.Add(account);
			_context.SaveChanges();
			MessageBox.Show("Success!");
			ClearFields();
		}
		else
		{
			MessageBox.Show("Error");
		}
	}
}
