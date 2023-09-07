namespace WinFormsTest.Forms
{
	partial class AddPlayerForm
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
			AddPlayerLabel = new Label();
			ClubsBox = new ComboBox();
			PositionsBox = new ComboBox();
			AddPlayerButton = new Button();
			ClubLabel = new Label();
			DressNumberLabel = new Label();
			DressNumberField = new TextBox();
			PositionLabel = new Label();
			PlayerNameLabel = new Label();
			NameField = new TextBox();
			SuspendLayout();
			// 
			// AddPlayerLabel
			// 
			AddPlayerLabel.AutoSize = true;
			AddPlayerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			AddPlayerLabel.Location = new Point(323, 32);
			AddPlayerLabel.Name = "AddPlayerLabel";
			AddPlayerLabel.Size = new Size(159, 32);
			AddPlayerLabel.TabIndex = 21;
			AddPlayerLabel.Text = "Dodaj igraca";
			// 
			// ClubsBox
			// 
			ClubsBox.FormattingEnabled = true;
			ClubsBox.Location = new Point(268, 256);
			ClubsBox.Name = "ClubsBox";
			ClubsBox.Size = new Size(275, 23);
			ClubsBox.TabIndex = 20;
			// 
			// PositionsBox
			// 
			PositionsBox.FormattingEnabled = true;
			PositionsBox.Location = new Point(268, 202);
			PositionsBox.Name = "PositionsBox";
			PositionsBox.Size = new Size(275, 23);
			PositionsBox.TabIndex = 19;
			// 
			// AddPlayerButton
			// 
			AddPlayerButton.BackColor = Color.FromArgb(0, 150, 136);
			AddPlayerButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			AddPlayerButton.ForeColor = Color.Gainsboro;
			AddPlayerButton.Location = new Point(285, 307);
			AddPlayerButton.Name = "AddPlayerButton";
			AddPlayerButton.Size = new Size(242, 43);
			AddPlayerButton.TabIndex = 18;
			AddPlayerButton.Text = "Dodaj";
			AddPlayerButton.UseVisualStyleBackColor = false;
			AddPlayerButton.Click += AddPlayerButton_Click;
			// 
			// ClubLabel
			// 
			ClubLabel.AutoSize = true;
			ClubLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			ClubLabel.Location = new Point(210, 257);
			ClubLabel.Name = "ClubLabel";
			ClubLabel.Size = new Size(40, 17);
			ClubLabel.TabIndex = 17;
			ClubLabel.Text = "Klub:";
			ClubLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// DressNumberLabel
			// 
			DressNumberLabel.AutoSize = true;
			DressNumberLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			DressNumberLabel.Location = new Point(210, 150);
			DressNumberLabel.Name = "DressNumberLabel";
			DressNumberLabel.Size = new Size(40, 17);
			DressNumberLabel.TabIndex = 16;
			DressNumberLabel.Text = "Dres:";
			DressNumberLabel.TextAlign = ContentAlignment.MiddleCenter;
			DressNumberLabel.Click += DressNumberLabel_Click;
			// 
			// DressNumberField
			// 
			DressNumberField.Location = new Point(268, 149);
			DressNumberField.Name = "DressNumberField";
			DressNumberField.Size = new Size(275, 23);
			DressNumberField.TabIndex = 15;
			// 
			// PositionLabel
			// 
			PositionLabel.AutoSize = true;
			PositionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			PositionLabel.Location = new Point(191, 203);
			PositionLabel.Name = "PositionLabel";
			PositionLabel.Size = new Size(59, 17);
			PositionLabel.TabIndex = 14;
			PositionLabel.Text = "Pozicija:";
			PositionLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// PlayerNameLabel
			// 
			PlayerNameLabel.AutoSize = true;
			PlayerNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			PlayerNameLabel.Location = new Point(215, 99);
			PlayerNameLabel.Name = "PlayerNameLabel";
			PlayerNameLabel.Size = new Size(35, 17);
			PlayerNameLabel.TabIndex = 13;
			PlayerNameLabel.Text = "Ime:";
			PlayerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
			PlayerNameLabel.Click += PlayerNameLabel_Click;
			// 
			// NameField
			// 
			NameField.Location = new Point(268, 98);
			NameField.Name = "NameField";
			NameField.Size = new Size(275, 23);
			NameField.TabIndex = 12;
			// 
			// AddPlayerForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(AddPlayerLabel);
			Controls.Add(ClubsBox);
			Controls.Add(PositionsBox);
			Controls.Add(AddPlayerButton);
			Controls.Add(ClubLabel);
			Controls.Add(DressNumberLabel);
			Controls.Add(DressNumberField);
			Controls.Add(PositionLabel);
			Controls.Add(PlayerNameLabel);
			Controls.Add(NameField);
			Name = "AddPlayerForm";
			Text = "AddPlayerForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label AddPlayerLabel;
		private ComboBox ClubsBox;
		private ComboBox PositionsBox;
		private Button AddPlayerButton;
		private Label ClubLabel;
		private Label DressNumberLabel;
		private TextBox DressNumberField;
		private Label PositionLabel;
		private Label PlayerNameLabel;
		private TextBox NameField;
	}
}