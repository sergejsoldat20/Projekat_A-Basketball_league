namespace WinFormsTest.Forms
{
	partial class TableForm
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
			TableData = new DataGridView();
			ClubNameTable = new DataGridViewTextBoxColumn();
			City = new DataGridViewTextBoxColumn();
			Season = new DataGridViewTextBoxColumn();
			PointsTable = new DataGridViewTextBoxColumn();
			ChooseSeasonButton = new Button();
			SeasonsBox = new ComboBox();
			TableLabel = new Label();
			((System.ComponentModel.ISupportInitialize)TableData).BeginInit();
			SuspendLayout();
			// 
			// TableData
			// 
			TableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			TableData.Columns.AddRange(new DataGridViewColumn[] { ClubNameTable, City, Season, PointsTable });
			TableData.Location = new Point(33, 149);
			TableData.Margin = new Padding(4, 3, 4, 3);
			TableData.Name = "TableData";
			TableData.RowTemplate.Height = 25;
			TableData.Size = new Size(444, 150);
			TableData.TabIndex = 1;
			// 
			// ClubNameTable
			// 
			ClubNameTable.HeaderText = "Klub";
			ClubNameTable.Name = "ClubNameTable";
			// 
			// City
			// 
			City.HeaderText = "Grad";
			City.Name = "City";
			// 
			// Season
			// 
			Season.HeaderText = "Sezona";
			Season.Name = "Season";
			// 
			// PointsTable
			// 
			PointsTable.HeaderText = "BrojPoena";
			PointsTable.Name = "PointsTable";
			// 
			// ChooseSeasonButton
			// 
			ChooseSeasonButton.BackColor = Color.FromArgb(0, 150, 136);
			ChooseSeasonButton.FlatAppearance.BorderSize = 0;
			ChooseSeasonButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ChooseSeasonButton.ForeColor = Color.Gainsboro;
			ChooseSeasonButton.Location = new Point(640, 149);
			ChooseSeasonButton.Margin = new Padding(4, 3, 4, 3);
			ChooseSeasonButton.Name = "ChooseSeasonButton";
			ChooseSeasonButton.Size = new Size(100, 24);
			ChooseSeasonButton.TabIndex = 4;
			ChooseSeasonButton.Text = "Izaberi";
			ChooseSeasonButton.UseVisualStyleBackColor = false;
			ChooseSeasonButton.Click += ChooseSeasonButton_Click;
			// 
			// SeasonsBox
			// 
			SeasonsBox.ForeColor = SystemColors.ActiveCaptionText;
			SeasonsBox.FormattingEnabled = true;
			SeasonsBox.Location = new Point(512, 149);
			SeasonsBox.Margin = new Padding(4, 3, 4, 3);
			SeasonsBox.Name = "SeasonsBox";
			SeasonsBox.Size = new Size(101, 23);
			SeasonsBox.TabIndex = 3;
			SeasonsBox.Text = "Sezona";
			// 
			// TableLabel
			// 
			TableLabel.AutoSize = true;
			TableLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			TableLabel.Location = new Point(33, 85);
			TableLabel.Name = "TableLabel";
			TableLabel.Size = new Size(101, 37);
			TableLabel.TabIndex = 5;
			TableLabel.Text = "Tabela";
			// 
			// TableForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(TableLabel);
			Controls.Add(ChooseSeasonButton);
			Controls.Add(SeasonsBox);
			Controls.Add(TableData);
			Name = "TableForm";
			Text = "TableForm";
			((System.ComponentModel.ISupportInitialize)TableData).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView TableData;
		private Button ChooseSeasonButton;
		private ComboBox SeasonsBox;
		private DataGridViewTextBoxColumn ClubNameTable;
		private DataGridViewTextBoxColumn City;
		private DataGridViewTextBoxColumn Season;
		private DataGridViewTextBoxColumn PointsTable;
		private Label TableLabel;
	}
}