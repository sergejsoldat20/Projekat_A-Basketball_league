namespace WinFormsTest.Forms
{
	partial class PlayersForm
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
			PlayersGridView = new DataGridView();
			AllPlayersLabel = new Label();
			NameTable = new DataGridViewTextBoxColumn();
			DressNumberTable = new DataGridViewTextBoxColumn();
			PositionTable = new DataGridViewTextBoxColumn();
			ClubTable = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)PlayersGridView).BeginInit();
			SuspendLayout();
			// 
			// PlayersGridView
			// 
			PlayersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PlayersGridView.Columns.AddRange(new DataGridViewColumn[] { NameTable, DressNumberTable, PositionTable, ClubTable });
			PlayersGridView.Location = new Point(123, 97);
			PlayersGridView.Name = "PlayersGridView";
			PlayersGridView.RowTemplate.Height = 25;
			PlayersGridView.Size = new Size(555, 222);
			PlayersGridView.TabIndex = 0;
			// 
			// AllPlayersLabel
			// 
			AllPlayersLabel.AutoSize = true;
			AllPlayersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			AllPlayersLabel.Location = new Point(123, 47);
			AllPlayersLabel.Name = "AllPlayersLabel";
			AllPlayersLabel.Size = new Size(215, 32);
			AllPlayersLabel.TabIndex = 1;
			AllPlayersLabel.Text = "Spisak svih igraca";
			// 
			// NameTable
			// 
			NameTable.HeaderText = "Ime i prezime";
			NameTable.Name = "NameTable";
			NameTable.Width = 150;
			// 
			// DressNumberTable
			// 
			DressNumberTable.HeaderText = "BrojDresa";
			DressNumberTable.Name = "DressNumberTable";
			DressNumberTable.Width = 120;
			// 
			// PositionTable
			// 
			PositionTable.HeaderText = "Pozicija";
			PositionTable.Name = "PositionTable";
			PositionTable.Width = 120;
			// 
			// ClubTable
			// 
			ClubTable.HeaderText = "Klub";
			ClubTable.Name = "ClubTable";
			ClubTable.Width = 120;
			// 
			// PlayersForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(AllPlayersLabel);
			Controls.Add(PlayersGridView);
			Name = "PlayersForm";
			StartPosition = FormStartPosition.CenterParent;
			Text = "PlayersForm";
			((System.ComponentModel.ISupportInitialize)PlayersGridView).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView PlayersGridView;
		private Label AllPlayersLabel;
		private DataGridViewTextBoxColumn NameTable;
		private DataGridViewTextBoxColumn DressNumberTable;
		private DataGridViewTextBoxColumn PositionTable;
		private DataGridViewTextBoxColumn ClubTable;
	}
}