namespace WinFormsTest.Forms
{
	partial class AddUserForm
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
			label1 = new Label();
			AddUserHeader = new Label();
			RolesBox = new ComboBox();
			AddAccountButton = new Button();
			RoleLabel = new Label();
			UsernameLabel = new Label();
			LastNameField = new TextBox();
			PasswordLabel = new Label();
			FirstNameLabel = new Label();
			FirstNameField = new TextBox();
			UsernameField = new TextBox();
			PasswordBox = new TextBox();
			LastNameLabel = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(284, 79);
			label1.Name = "label1";
			label1.Size = new Size(0, 15);
			label1.TabIndex = 0;
			// 
			// AddUserHeader
			// 
			AddUserHeader.AutoSize = true;
			AddUserHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			AddUserHeader.Location = new Point(323, 37);
			AddUserHeader.Name = "AddUserHeader";
			AddUserHeader.Size = new Size(193, 32);
			AddUserHeader.TabIndex = 31;
			AddUserHeader.Text = "Dodaj korisnika";
			// 
			// RolesBox
			// 
			RolesBox.FormattingEnabled = true;
			RolesBox.Location = new Point(284, 265);
			RolesBox.Name = "RolesBox";
			RolesBox.Size = new Size(275, 23);
			RolesBox.TabIndex = 30;
			// 
			// AddAccountButton
			// 
			AddAccountButton.BackColor = Color.FromArgb(0, 150, 136);
			AddAccountButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			AddAccountButton.ForeColor = Color.Gainsboro;
			AddAccountButton.Location = new Point(301, 313);
			AddAccountButton.Name = "AddAccountButton";
			AddAccountButton.Size = new Size(242, 43);
			AddAccountButton.TabIndex = 28;
			AddAccountButton.Text = "Dodaj";
			AddAccountButton.UseVisualStyleBackColor = false;
			AddAccountButton.Click += AddPlayerButton_Click;
			// 
			// RoleLabel
			// 
			RoleLabel.AutoSize = true;
			RoleLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			RoleLabel.Location = new Point(203, 266);
			RoleLabel.Name = "RoleLabel";
			RoleLabel.Size = new Size(48, 17);
			RoleLabel.TabIndex = 27;
			RoleLabel.Text = "Uloga:";
			// 
			// UsernameLabel
			// 
			UsernameLabel.AutoSize = true;
			UsernameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			UsernameLabel.Location = new Point(148, 180);
			UsernameLabel.Name = "UsernameLabel";
			UsernameLabel.Size = new Size(103, 17);
			UsernameLabel.TabIndex = 26;
			UsernameLabel.Text = "Korisnicko ime:";
			// 
			// LastNameField
			// 
			LastNameField.Location = new Point(284, 135);
			LastNameField.Name = "LastNameField";
			LastNameField.Size = new Size(275, 23);
			LastNameField.TabIndex = 25;
			// 
			// PasswordLabel
			// 
			PasswordLabel.AutoSize = true;
			PasswordLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			PasswordLabel.Location = new Point(192, 222);
			PasswordLabel.Name = "PasswordLabel";
			PasswordLabel.Size = new Size(59, 17);
			PasswordLabel.TabIndex = 24;
			PasswordLabel.Text = "Lozinka:";
			// 
			// FirstNameLabel
			// 
			FirstNameLabel.AutoSize = true;
			FirstNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			FirstNameLabel.Location = new Point(188, 97);
			FirstNameLabel.Name = "FirstNameLabel";
			FirstNameLabel.Size = new Size(63, 17);
			FirstNameLabel.TabIndex = 23;
			FirstNameLabel.Text = "       Ime:";
			// 
			// FirstNameField
			// 
			FirstNameField.Location = new Point(284, 97);
			FirstNameField.Name = "FirstNameField";
			FirstNameField.Size = new Size(275, 23);
			FirstNameField.TabIndex = 22;
			// 
			// UsernameField
			// 
			UsernameField.Location = new Point(284, 179);
			UsernameField.Name = "UsernameField";
			UsernameField.Size = new Size(275, 23);
			UsernameField.TabIndex = 32;
			// 
			// PasswordBox
			// 
			PasswordBox.Location = new Point(284, 221);
			PasswordBox.Name = "PasswordBox";
			PasswordBox.PasswordChar = '*';
			PasswordBox.Size = new Size(275, 23);
			PasswordBox.TabIndex = 33;
			// 
			// LastNameLabel
			// 
			LastNameLabel.AutoSize = true;
			LastNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			LastNameLabel.Location = new Point(190, 136);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new Size(69, 17);
			LastNameLabel.TabIndex = 34;
			LastNameLabel.Text = "  Prezime:";
			// 
			// AddUserForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(LastNameLabel);
			Controls.Add(PasswordBox);
			Controls.Add(UsernameField);
			Controls.Add(AddUserHeader);
			Controls.Add(RolesBox);
			Controls.Add(AddAccountButton);
			Controls.Add(RoleLabel);
			Controls.Add(UsernameLabel);
			Controls.Add(LastNameField);
			Controls.Add(PasswordLabel);
			Controls.Add(FirstNameLabel);
			Controls.Add(FirstNameField);
			// Controls.Add(label1);
			Name = "AddUserForm";
			Text = "AddUserForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label AddUserHeader;
		private ComboBox RolesBox;
		private Button AddAccountButton;
		private Label RoleLabel;
		private Label UsernameLabel;
		private TextBox LastNameField;
		private Label PasswordLabel;
		private Label FirstNameLabel;
		private TextBox FirstNameField;
		private TextBox UsernameField;
		private TextBox PasswordBox;
		private Label LastNameLabel;
	}
}