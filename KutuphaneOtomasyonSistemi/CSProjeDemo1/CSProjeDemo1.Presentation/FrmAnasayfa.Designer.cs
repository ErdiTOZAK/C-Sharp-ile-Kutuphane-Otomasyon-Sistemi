namespace CSProjeDemo1.Presentation
{
	partial class frmAnasayfa
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
			btnUyeIslemler = new Button();
			btnKitapIslemler = new Button();
			btnEmanetIslemler = new Button();
			SuspendLayout();
			// 
			// btnUyeIslemler
			// 
			btnUyeIslemler.BackColor = Color.Yellow;
			btnUyeIslemler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			btnUyeIslemler.Location = new Point(172, 121);
			btnUyeIslemler.Name = "btnUyeIslemler";
			btnUyeIslemler.Size = new Size(396, 89);
			btnUyeIslemler.TabIndex = 0;
			btnUyeIslemler.Text = "ÜYE İŞLEMLERİ";
			btnUyeIslemler.UseVisualStyleBackColor = false;
			btnUyeIslemler.Click += btnUyeIslemler_Click;
			// 
			// btnKitapIslemler
			// 
			btnKitapIslemler.BackColor = Color.Yellow;
			btnKitapIslemler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			btnKitapIslemler.Location = new Point(172, 293);
			btnKitapIslemler.Name = "btnKitapIslemler";
			btnKitapIslemler.Size = new Size(396, 89);
			btnKitapIslemler.TabIndex = 1;
			btnKitapIslemler.Text = "KİTAP İŞLEMLERİ";
			btnKitapIslemler.UseVisualStyleBackColor = false;
			btnKitapIslemler.Click += btnKitapIslemler_Click;
			// 
			// btnEmanetIslemler
			// 
			btnEmanetIslemler.BackColor = Color.Yellow;
			btnEmanetIslemler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			btnEmanetIslemler.Location = new Point(172, 461);
			btnEmanetIslemler.Name = "btnEmanetIslemler";
			btnEmanetIslemler.Size = new Size(396, 89);
			btnEmanetIslemler.TabIndex = 2;
			btnEmanetIslemler.Text = "EMANET İŞLEMLERİ";
			btnEmanetIslemler.UseVisualStyleBackColor = false;
			btnEmanetIslemler.Click += btnEmanetIslemler_Click;
			// 
			// frmAnasayfa
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(701, 695);
			Controls.Add(btnEmanetIslemler);
			Controls.Add(btnKitapIslemler);
			Controls.Add(btnUyeIslemler);
			Name = "frmAnasayfa";
			Text = "ANASAYFA";
			ResumeLayout(false);
		}

		#endregion

		private Button btnUyeIslemler;
		private Button btnKitapIslemler;
		private Button btnEmanetIslemler;
	}
}
