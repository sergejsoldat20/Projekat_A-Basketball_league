namespace WinFormsTest.Forms
{
	partial class AddGamesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PointsGuest = new TextBox();
			PointsHome = new TextBox();
			CityBox = new ComboBox();
			ArenaBox = new ComboBox();
			GuestClubs = new ComboBox();
			HomeClubs = new ComboBox();
			GameTimePicker = new DateTimePicker();
			AddGameButton = new Button();
			AddGameLabel = new Label();
			HomeLabel = new Label();
			GuestLabel = new Label();
			CityLabel = new Label();
			ArenaLabel = new Label();
			GameTimeLabel = new Label();
			HomePointsLabel = new Label();
			GuestPointsLabel = new Label();
			SuspendLayout();
			// 
			// PointsGuest
			// 
			PointsGuest.Location = new Point(302, 294);
			PointsGuest.Name = "PointsGuest";
			PointsGuest.Size = new Size(85, 23);
			PointsGuest.TabIndex = 0;
			// 
			// PointsHome
			// 
			PointsHome.Location = new Point(302, 265);
			PointsHome.Name = "PointsHome";
			PointsHome.Size = new Size(85, 23);
			PointsHome.TabIndex = 1;
			// 
			// CityBox
			// 
			CityBox.FormattingEnabled = true;
			CityBox.Location = new Point(302, 178);
			CityBox.Name = "CityBox";
			CityBox.Size = new Size(230, 23);
			CityBox.TabIndex = 2;
			// 
			// ArenaBox
			// 
			ArenaBox.FormattingEnabled = true;
			ArenaBox.Location = new Point(302, 207);
			ArenaBox.Name = "ArenaBox";
			ArenaBox.Size = new Size(230, 23);
			ArenaBox.TabIndex = 3;
			// 
			// GuestClubs
			// 
			GuestClubs.FormattingEnabled = true;
			GuestClubs.Location = new Point(302, 149);
			GuestClubs.Name = "GuestClubs";
			GuestClubs.Size = new Size(230, 23);
			GuestClubs.TabIndex = 4;
			// 
			// HomeClubs
			// 
			HomeClubs.FormattingEnabled = true;
			HomeClubs.Location = new Point(302, 120);
			HomeClubs.Name = "HomeClubs";
			HomeClubs.Size = new Size(230, 23);
			HomeClubs.TabIndex = 5;
			// 
			// GameTimePicker
			// 
			GameTimePicker.Location = new Point(302, 236);
			GameTimePicker.Name = "GameTimePicker";
			GameTimePicker.Size = new Size(230, 23);
			GameTimePicker.TabIndex = 6;
			// 
			// AddGameButton
			// 
			AddGameButton.BackColor = Color.FromArgb(0, 150, 136);
			AddGameButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			AddGameButton.ForeColor = Color.Gainsboro;
			AddGameButton.Location = new Point(342, 335);
			AddGameButton.Name = "AddGameButton";
			AddGameButton.Size = new Size(164, 42);
			AddGameButton.TabIndex = 7;
			AddGameButton.Text = "Dodaj";
			AddGameButton.UseVisualStyleBackColor = false;
			AddGameButton.Click += AddGameButton_Click;
			// 
			// AddGameLabel
			// 
			AddGameLabel.AutoSize = true;
			AddGameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			AddGameLabel.Location = new Point(288, 51);
			AddGameLabel.Name = "AddGameLabel";
			AddGameLabel.Size = new Size(260, 32);
			AddGameLabel.TabIndex = 8;
			AddGameLabel.Text = "Dodaj novu utakmicu";
			// 
			// HomeLabel
			// 
			HomeLabel.AutoSize = true;
			HomeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			HomeLabel.Location = new Point(217, 121);
			HomeLabel.Name = "HomeLabel";
			HomeLabel.Size = new Size(59, 17);
			HomeLabel.TabIndex = 9;
			HomeLabel.Text = "Domaci:";
			// 
			// GuestLabel
			// 
			GuestLabel.AutoSize = true;
			GuestLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			GuestLabel.Location = new Point(232, 150);
			GuestLabel.Name = "GuestLabel";
			GuestLabel.Size = new Size(44, 17);
			GuestLabel.TabIndex = 10;
			GuestLabel.Text = "Gosti:";
			// 
			// CityLabel
			// 
			CityLabel.AutoSize = true;
			CityLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			CityLabel.Location = new Point(235, 179);
			CityLabel.Name = "CityLabel";
			CityLabel.Size = new Size(41, 17);
			CityLabel.TabIndex = 11;
			CityLabel.Text = "Grad:";
			// 
			// ArenaLabel
			// 
			ArenaLabel.AutoSize = true;
			ArenaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			ArenaLabel.Location = new Point(228, 208);
			ArenaLabel.Name = "ArenaLabel";
			ArenaLabel.Size = new Size(48, 17);
			ArenaLabel.TabIndex = 12;
			ArenaLabel.Text = "Arena:";
			// 
			// GameTimeLabel
			// 
			GameTimeLabel.AutoSize = true;
			GameTimeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			GameTimeLabel.Location = new Point(216, 240);
			GameTimeLabel.Name = "GameTimeLabel";
			GameTimeLabel.Size = new Size(60, 17);
			GameTimeLabel.TabIndex = 13;
			GameTimeLabel.Text = "Vrijeme:";
			// 
			// HomePointsLabel
			// 
			HomePointsLabel.AutoSize = true;
			HomePointsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			HomePointsLabel.Location = new Point(180, 266);
			HomePointsLabel.Name = "HomePointsLabel";
			HomePointsLabel.Size = new Size(96, 17);
			HomePointsLabel.TabIndex = 14;
			HomePointsLabel.Text = "Poeni domaci:";
			HomePointsLabel.Click += label7_Click;
			// 
			// GuestPointsLabel
			// 
			GuestPointsLabel.AutoSize = true;
			GuestPointsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			GuestPointsLabel.Location = new Point(194, 295);
			GuestPointsLabel.Name = "GuestPointsLabel";
			GuestPointsLabel.Size = new Size(82, 17);
			GuestPointsLabel.TabIndex = 15;
			GuestPointsLabel.Text = "Poeni gosti:";
			// 
			// AddGamesForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(GuestPointsLabel);
			Controls.Add(HomePointsLabel);
			Controls.Add(GameTimeLabel);
			Controls.Add(ArenaLabel);
			Controls.Add(CityLabel);
			Controls.Add(GuestLabel);
			Controls.Add(HomeLabel);
			Controls.Add(AddGameLabel);
			Controls.Add(AddGameButton);
			Controls.Add(GameTimePicker);
			Controls.Add(HomeClubs);
			Controls.Add(GuestClubs);
			Controls.Add(ArenaBox);
			Controls.Add(CityBox);
			Controls.Add(PointsHome);
			Controls.Add(PointsGuest);
			Name = "AddGamesForm";
			Text = "TableForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox PointsGuest;
		private TextBox PointsHome;
		private ComboBox CityBox;
		private ComboBox ArenaBox;
		private ComboBox GuestClubs;
		private ComboBox HomeClubs;
		private DateTimePicker GameTimePicker;
		private Button AddGameButton;
		private Label AddGameLabel;
		private Label HomeLabel;
		private Label GuestLabel;
		private Label CityLabel;
		private Label ArenaLabel;
		private Label GameTimeLabel;
		private Label HomePointsLabel;
		private Label GuestPointsLabel;
	}
}