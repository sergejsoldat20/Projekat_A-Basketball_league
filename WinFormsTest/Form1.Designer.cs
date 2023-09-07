namespace WinFormsTest
{
	partial class Form1
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
			components = new System.ComponentModel.Container();
			menuItemsPanel = new Panel();
			ChangeLanguageButton = new Button();
			LanguagesBox = new ComboBox();
			AddNewAccountButton = new Button();
			GamesButton = new Button();
			AddNewGameButton = new Button();
			AddNewPlayerButton = new Button();
			PlayersButton = new Button();
			TableButton = new Button();
			logoPanel = new Panel();
			contextMenuStrip1 = new ContextMenuStrip(components);
			panel1 = new Panel();
			MainHeader = new Label();
			ParentPanel = new Panel();
			menuItemsPanel.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// menuItemsPanel
			// 
			menuItemsPanel.BackColor = Color.FromArgb(51, 51, 76);
			menuItemsPanel.Controls.Add(ChangeLanguageButton);
			menuItemsPanel.Controls.Add(LanguagesBox);
			menuItemsPanel.Controls.Add(AddNewAccountButton);
			menuItemsPanel.Controls.Add(GamesButton);
			menuItemsPanel.Controls.Add(AddNewGameButton);
			menuItemsPanel.Controls.Add(AddNewPlayerButton);
			menuItemsPanel.Controls.Add(PlayersButton);
			menuItemsPanel.Controls.Add(TableButton);
			menuItemsPanel.Controls.Add(logoPanel);
			menuItemsPanel.Dock = DockStyle.Left;
			menuItemsPanel.Location = new Point(0, 0);
			menuItemsPanel.Name = "menuItemsPanel";
			menuItemsPanel.Size = new Size(240, 554);
			menuItemsPanel.TabIndex = 6;
			// 
			// ChangeLanguageButton
			// 
			ChangeLanguageButton.BackColor = Color.FromArgb(0, 150, 136);
			ChangeLanguageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ChangeLanguageButton.ForeColor = Color.Gainsboro;
			ChangeLanguageButton.Location = new Point(124, 446);
			ChangeLanguageButton.Name = "ChangeLanguageButton";
			ChangeLanguageButton.Size = new Size(89, 24);
			ChangeLanguageButton.TabIndex = 0;
			ChangeLanguageButton.Text = "Prevedi\r\n";
			ChangeLanguageButton.UseVisualStyleBackColor = false;
			ChangeLanguageButton.Click += ChangeLanguageButton_Click;
			// 
			// LanguagesBox
			// 
			LanguagesBox.FormattingEnabled = true;
			LanguagesBox.Location = new Point(24, 446);
			LanguagesBox.Name = "LanguagesBox";
			LanguagesBox.Size = new Size(67, 23);
			LanguagesBox.TabIndex = 0;
			// 
			// AddNewAccountButton
			// 
			AddNewAccountButton.Dock = DockStyle.Top;
			AddNewAccountButton.FlatStyle = FlatStyle.Flat;
			AddNewAccountButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			AddNewAccountButton.ForeColor = Color.Gainsboro;
			AddNewAccountButton.Location = new Point(0, 327);
			AddNewAccountButton.Name = "AddNewAccountButton";
			AddNewAccountButton.Size = new Size(240, 50);
			AddNewAccountButton.TabIndex = 7;
			AddNewAccountButton.Text = "Dodaj korisnika";
			AddNewAccountButton.UseVisualStyleBackColor = true;
			AddNewAccountButton.Click += AddAccountButton_Click;
			// 
			// GamesButton
			// 
			GamesButton.Dock = DockStyle.Top;
			GamesButton.FlatStyle = FlatStyle.Flat;
			GamesButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			GamesButton.ForeColor = Color.Gainsboro;
			GamesButton.Location = new Point(0, 277);
			GamesButton.Name = "GamesButton";
			GamesButton.Size = new Size(240, 50);
			GamesButton.TabIndex = 6;
			GamesButton.Text = "Utakmice";
			GamesButton.UseVisualStyleBackColor = true;
			GamesButton.Click += GamesButton_Click;
			// 
			// AddNewGameButton
			// 
			AddNewGameButton.Dock = DockStyle.Top;
			AddNewGameButton.FlatStyle = FlatStyle.Flat;
			AddNewGameButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			AddNewGameButton.ForeColor = Color.Gainsboro;
			AddNewGameButton.Location = new Point(0, 227);
			AddNewGameButton.Name = "AddNewGameButton";
			AddNewGameButton.Size = new Size(240, 50);
			AddNewGameButton.TabIndex = 5;
			AddNewGameButton.Text = "Dodaj utakmicu";
			AddNewGameButton.UseVisualStyleBackColor = true;
			AddNewGameButton.Click += AddGameButton_Click;
			// 
			// AddNewPlayerButton
			// 
			AddNewPlayerButton.Dock = DockStyle.Top;
			AddNewPlayerButton.FlatStyle = FlatStyle.Flat;
			AddNewPlayerButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			AddNewPlayerButton.ForeColor = Color.Gainsboro;
			AddNewPlayerButton.Location = new Point(0, 177);
			AddNewPlayerButton.Name = "AddNewPlayerButton";
			AddNewPlayerButton.Size = new Size(240, 50);
			AddNewPlayerButton.TabIndex = 4;
			AddNewPlayerButton.Text = "Dodaj igraca\r\n";
			AddNewPlayerButton.UseVisualStyleBackColor = true;
			AddNewPlayerButton.Click += AddPlayerButton_Click;
			// 
			// PlayersButton
			// 
			PlayersButton.Dock = DockStyle.Top;
			PlayersButton.FlatStyle = FlatStyle.Flat;
			PlayersButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			PlayersButton.ForeColor = Color.Gainsboro;
			PlayersButton.Location = new Point(0, 127);
			PlayersButton.Name = "PlayersButton";
			PlayersButton.Size = new Size(240, 50);
			PlayersButton.TabIndex = 2;
			PlayersButton.Text = "Igraci";
			PlayersButton.UseVisualStyleBackColor = true;
			PlayersButton.Click += PlayersButton_Click;
			// 
			// TableButton
			// 
			TableButton.Dock = DockStyle.Top;
			TableButton.FlatStyle = FlatStyle.Flat;
			TableButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
			TableButton.ForeColor = Color.Gainsboro;
			TableButton.Location = new Point(0, 77);
			TableButton.Name = "TableButton";
			TableButton.Size = new Size(240, 50);
			TableButton.TabIndex = 1;
			TableButton.Text = "Tabela";
			TableButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			TableButton.UseVisualStyleBackColor = true;
			TableButton.Click += TableButton_Click;
			// 
			// logoPanel
			// 
			logoPanel.BackColor = Color.FromArgb(39, 39, 58);
			logoPanel.BorderStyle = BorderStyle.FixedSingle;
			logoPanel.Dock = DockStyle.Top;
			logoPanel.Location = new Point(0, 0);
			logoPanel.Name = "logoPanel";
			logoPanel.Size = new Size(240, 77);
			logoPanel.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(61, 4);
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(0, 150, 136);
			panel1.Controls.Add(MainHeader);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(240, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(851, 77);
			panel1.TabIndex = 7;
			// 
			// MainHeader
			// 
			MainHeader.AutoSize = true;
			MainHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			MainHeader.ForeColor = Color.Gainsboro;
			MainHeader.Location = new Point(327, 22);
			MainHeader.Name = "MainHeader";
			MainHeader.Size = new Size(191, 32);
			MainHeader.TabIndex = 0;
			MainHeader.Text = "Kosarkaska liga";
			// 
			// ParentPanel
			// 
			ParentPanel.Dock = DockStyle.Fill;
			ParentPanel.Location = new Point(240, 77);
			ParentPanel.Name = "ParentPanel";
			ParentPanel.Size = new Size(851, 477);
			ParentPanel.TabIndex = 8;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.WhiteSmoke;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(1091, 554);
			Controls.Add(ParentPanel);
			Controls.Add(panel1);
			Controls.Add(menuItemsPanel);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "HCI";
			Load += Form1_Load;
			menuItemsPanel.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel menuItemsPanel;
		private Button PlayersButton;
		private Button TableButton;
		private Button GamesButton;
		private Button AddNewGameButton;
		private Button AddNewPlayerButton;
		public Panel logoPanel;
		private ContextMenuStrip contextMenuStrip1;
		private Panel panel1;
		private Label MainHeader;
		private Panel ParentPanel;
		private Button AddNewAccountButton;
		private Button ChangeLanguageButton;
		private ComboBox LanguagesBox;
	}
}