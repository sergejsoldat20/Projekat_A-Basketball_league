using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest.Forms
{
	public partial class GamesForm : Form
	{
		public GamesForm()
		{
			InitializeComponent();

			// Remove title bar, borders, and buttons
			FormBorderStyle = FormBorderStyle.None;
			ControlBox = false;
			MaximizeBox = false;
			MinimizeBox = false;
		}
	}
}
