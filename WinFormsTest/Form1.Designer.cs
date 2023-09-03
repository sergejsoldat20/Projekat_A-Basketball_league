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
			menuItemsPanel = new Panel();
			logoPanel = new Panel();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			menuItemsPanel.SuspendLayout();
			SuspendLayout();
			// 
			// menuItemsPanel
			// 
			menuItemsPanel.BackColor = Color.FromArgb(51, 51, 76);
			menuItemsPanel.Controls.Add(button3);
			menuItemsPanel.Controls.Add(button2);
			menuItemsPanel.Controls.Add(button1);
			menuItemsPanel.Controls.Add(logoPanel);
			menuItemsPanel.Dock = DockStyle.Left;
			menuItemsPanel.Location = new Point(0, 0);
			menuItemsPanel.Name = "menuItemsPanel";
			menuItemsPanel.Size = new Size(240, 554);
			menuItemsPanel.TabIndex = 6;
			menuItemsPanel.Paint += panelLogo_Paint;
			// 
			// logoPanel
			// 
			logoPanel.BackColor = Color.FromArgb(39, 39, 58);
			logoPanel.Dock = DockStyle.Top;
			logoPanel.Location = new Point(0, 0);
			logoPanel.Name = "logoPanel";
			logoPanel.Size = new Size(240, 77);
			logoPanel.TabIndex = 0;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Top;
			button1.ForeColor = Color.White;
			button1.Location = new Point(0, 77);
			button1.Name = "button1";
			button1.Size = new Size(240, 50);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Dock = DockStyle.Top;
			button2.Location = new Point(0, 127);
			button2.Name = "button2";
			button2.Size = new Size(240, 50);
			button2.TabIndex = 2;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Dock = DockStyle.Top;
			button3.Location = new Point(0, 177);
			button3.Name = "button3";
			button3.Size = new Size(240, 40);
			button3.TabIndex = 3;
			button3.Text = "button3";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(1091, 554);
			Controls.Add(menuItemsPanel);
			DoubleBuffered = true;
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			menuItemsPanel.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel menuItemsPanel;
		private Panel logoPanel;
		private Button button3;
		private Button button2;
		private Button button1;
	}
}