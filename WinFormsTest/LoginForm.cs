using Microsoft.VisualBasic.FileIO;
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

namespace WinFormsTest;

public partial class LoginForm : Form
{
	private ApplicationDbContext _context;
	public LoginForm(ApplicationDbContext context)
	{
		InitializeComponent();
		_context = context;
	}

	private void LoginButton_Click(object sender, EventArgs e)
	{
		// check user and route to mainform(form1)

		if (!string.IsNullOrWhiteSpace(UsernameField.Text) &&
			!string.IsNullOrWhiteSpace(PasswordField.Text))
		{
			var username = UsernameField.Text;
			var password = PasswordField.Text;
			var user = _context.Account.Where(x => x.Username == username
			&& x.Password == password).FirstOrDefault();

			if (user != null)
			{
				Form1 form = new Form1(_context, user.Role);
				form.Show();
			}
			else
			{
				MessageBox.Show("Error!");
			}
		}
		else
		{
			MessageBox.Show("Error!");
		}

	}
}
