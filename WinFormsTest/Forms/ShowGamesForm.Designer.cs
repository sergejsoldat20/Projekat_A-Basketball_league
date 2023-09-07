namespace WinFormsTest.Forms
{
	partial class ShowGamesForm
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
			GamesGrid = new DataGridView();
			AllGamesLabel = new Label();
			HomeTable = new DataGridViewTextBoxColumn();
			GuestTable = new DataGridViewTextBoxColumn();
			CityTable = new DataGridViewTextBoxColumn();
			ArenaTable = new DataGridViewTextBoxColumn();
			PointsHomeTable = new DataGridViewTextBoxColumn();
			PointsGuestTable = new DataGridViewTextBoxColumn();
			GameTimeTable = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)GamesGrid).BeginInit();
			SuspendLayout();
			// 
			// GamesGrid
			// 
			GamesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			GamesGrid.Columns.AddRange(new DataGridViewColumn[] { HomeTable, GuestTable, CityTable, ArenaTable, PointsHomeTable, PointsGuestTable, GameTimeTable });
			GamesGrid.Location = new Point(29, 121);
			GamesGrid.Name = "GamesGrid";
			GamesGrid.RowTemplate.Height = 25;
			GamesGrid.Size = new Size(743, 259);
			GamesGrid.TabIndex = 0;
			// 
			// AllGamesLabel
			// 
			AllGamesLabel.AutoSize = true;
			AllGamesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			AllGamesLabel.Location = new Point(29, 41);
			AllGamesLabel.Name = "AllGamesLabel";
			AllGamesLabel.Size = new Size(120, 32);
			AllGamesLabel.TabIndex = 1;
			AllGamesLabel.Text = "Utakmice";
			// 
			// HomeTable
			// 
			HomeTable.HeaderText = "Domaci";
			HomeTable.Name = "HomeTable";
			// 
			// GuestTable
			// 
			GuestTable.HeaderText = "Gosti";
			GuestTable.Name = "GuestTable";
			// 
			// CityTable
			// 
			CityTable.HeaderText = "Grad";
			CityTable.Name = "CityTable";
			// 
			// ArenaTable
			// 
			ArenaTable.HeaderText = "Arena";
			ArenaTable.Name = "ArenaTable";
			// 
			// PointsHomeTable
			// 
			PointsHomeTable.HeaderText = "Poeni domaci";
			PointsHomeTable.Name = "PointsHomeTable";
			// 
			// PointsGuestTable
			// 
			PointsGuestTable.HeaderText = "Poeni gosti";
			PointsGuestTable.Name = "PointsGuestTable";
			// 
			// GameTimeTable
			// 
			GameTimeTable.HeaderText = "Vrijeme";
			GameTimeTable.Name = "GameTimeTable";
			// 
			// ShowGamesForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(AllGamesLabel);
			Controls.Add(GamesGrid);
			Name = "ShowGamesForm";
			Text = "ShowGamesForm";
			((System.ComponentModel.ISupportInitialize)GamesGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView GamesGrid;
		private Label AllGamesLabel;
		private DataGridViewTextBoxColumn HomeTable;
		private DataGridViewTextBoxColumn GuestTable;
		private DataGridViewTextBoxColumn CityTable;
		private DataGridViewTextBoxColumn ArenaTable;
		private DataGridViewTextBoxColumn PointsHomeTable;
		private DataGridViewTextBoxColumn PointsGuestTable;
		private DataGridViewTextBoxColumn GameTimeTable;
	}
}