namespace WinFormsTest
{
	partial class LoginForm
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
			panel1 = new Panel();
			LoginButton = new Button();
			PasswordField = new TextBox();
			UsernameField = new TextBox();
			LoginLabel = new Label();
			HeaderPanel = new Panel();
			label1 = new Label();
			panel1.SuspendLayout();
			HeaderPanel.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Gainsboro;
			panel1.Controls.Add(LoginButton);
			panel1.Controls.Add(PasswordField);
			panel1.Controls.Add(UsernameField);
			panel1.Controls.Add(LoginLabel);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(753, 406);
			panel1.TabIndex = 1;
			// 
			// LoginButton
			// 
			LoginButton.BackColor = Color.FromArgb(0, 150, 136);
			LoginButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			LoginButton.ForeColor = Color.Gainsboro;
			LoginButton.Location = new Point(265, 235);
			LoginButton.Name = "LoginButton";
			LoginButton.Size = new Size(213, 38);
			LoginButton.TabIndex = 3;
			LoginButton.Text = "Prijava";
			LoginButton.UseVisualStyleBackColor = false;
			LoginButton.Click += LoginButton_Click;
			// 
			// PasswordField
			// 
			PasswordField.Location = new Point(265, 193);
			PasswordField.Name = "PasswordField";
			PasswordField.PasswordChar = '*';
			PasswordField.PlaceholderText = "Lozinka";
			PasswordField.Size = new Size(213, 23);
			PasswordField.TabIndex = 2;
			// 
			// UsernameField
			// 
			UsernameField.Location = new Point(265, 150);
			UsernameField.Name = "UsernameField";
			UsernameField.PlaceholderText = "Korisnicko ime";
			UsernameField.Size = new Size(213, 23);
			UsernameField.TabIndex = 1;
			// 
			// LoginLabel
			// 
			LoginLabel.AutoSize = true;
			LoginLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			LoginLabel.Location = new Point(323, 102);
			LoginLabel.Name = "LoginLabel";
			LoginLabel.Size = new Size(90, 25);
			LoginLabel.TabIndex = 0;
			LoginLabel.Text = "Prijavi se";
			// 
			// HeaderPanel
			// 
			HeaderPanel.BackColor = Color.FromArgb(0, 150, 136);
			HeaderPanel.Controls.Add(label1);
			HeaderPanel.Dock = DockStyle.Top;
			HeaderPanel.ForeColor = SystemColors.ControlText;
			HeaderPanel.Location = new Point(0, 0);
			HeaderPanel.Name = "HeaderPanel";
			HeaderPanel.Size = new Size(753, 68);
			HeaderPanel.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Gainsboro;
			label1.Location = new Point(235, 21);
			label1.Name = "label1";
			label1.Size = new Size(266, 30);
			label1.TabIndex = 0;
			label1.Text = "Interakcija covjek-racunar";
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(753, 406);
			Controls.Add(HeaderPanel);
			Controls.Add(panel1);
			Name = "LoginForm";
			Text = "LoginForm";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			HeaderPanel.ResumeLayout(false);
			HeaderPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel panel1;
		private Button LoginButton;
		private TextBox PasswordField;
		private TextBox UsernameField;
		private Label LoginLabel;
		private Panel HeaderPanel;
		private Label label1;
	}
}