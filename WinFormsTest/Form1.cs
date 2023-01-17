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

namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var clubs = context
                    .Club
                    .Where(x => x.Name == "Crvena Zvezda")
                    .ToList();
                var player = new BasketballPlayer()
                {
                    ClubId = clubs.FirstOrDefault().Id,
                    Name = "Sergej Soldat",
                    DressNumber = "5",
                    Position = "plej",
                };
                context.BasketballPlayer.Add(player);
                context.SaveChanges();
                MessageBox.Show(textBox1.Text);
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
