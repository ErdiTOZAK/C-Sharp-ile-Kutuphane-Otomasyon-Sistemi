namespace CSProjeDemo1.Presentation
{
	partial class frmUyeIslemler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeIslemler));
			grpUyeKayitFormu = new GroupBox();
			lblUyeId = new Label();
			pictureBox1 = new PictureBox();
			label5 = new Label();
			dgwUyeler = new DataGridView();
			cmsUyeler = new ContextMenuStrip(components);
			silToolStripMenuItem = new ToolStripMenuItem();
			güncelleToolStripMenuItem = new ToolStripMenuItem();
			txtUyeSoyadi = new TextBox();
			txtUyeAdi = new TextBox();
			chkKadin = new CheckBox();
			chkErkek = new CheckBox();
			btnUyeGuncelle = new Button();
			btnUyeEkle = new Button();
			txtUyeNo = new TextBox();
			lblCinsiyet = new Label();
			lblSoyad = new Label();
			lblAd = new Label();
			lblUyeNo = new Label();
			grpUyeKayitFormu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgwUyeler).BeginInit();
			cmsUyeler.SuspendLayout();
			SuspendLayout();
			// 
			// grpUyeKayitFormu
			// 
			grpUyeKayitFormu.BackColor = Color.FromArgb(192, 192, 255);
			grpUyeKayitFormu.Controls.Add(lblUyeId);
			grpUyeKayitFormu.Controls.Add(pictureBox1);
			grpUyeKayitFormu.Controls.Add(label5);
			grpUyeKayitFormu.Controls.Add(dgwUyeler);
			grpUyeKayitFormu.Controls.Add(txtUyeSoyadi);
			grpUyeKayitFormu.Controls.Add(txtUyeAdi);
			grpUyeKayitFormu.Controls.Add(chkKadin);
			grpUyeKayitFormu.Controls.Add(chkErkek);
			grpUyeKayitFormu.Controls.Add(btnUyeGuncelle);
			grpUyeKayitFormu.Controls.Add(btnUyeEkle);
			grpUyeKayitFormu.Controls.Add(txtUyeNo);
			grpUyeKayitFormu.Controls.Add(lblCinsiyet);
			grpUyeKayitFormu.Controls.Add(lblSoyad);
			grpUyeKayitFormu.Controls.Add(lblAd);
			grpUyeKayitFormu.Controls.Add(lblUyeNo);
			grpUyeKayitFormu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			grpUyeKayitFormu.Location = new Point(3, 2);
			grpUyeKayitFormu.Name = "grpUyeKayitFormu";
			grpUyeKayitFormu.Size = new Size(1406, 795);
			grpUyeKayitFormu.TabIndex = 0;
			grpUyeKayitFormu.TabStop = false;
			grpUyeKayitFormu.Text = "Üye Kayıt Formu";
			// 
			// lblUyeId
			// 
			lblUyeId.AutoSize = true;
			lblUyeId.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblUyeId.ForeColor = Color.Red;
			lblUyeId.Location = new Point(706, 138);
			lblUyeId.Name = "lblUyeId";
			lblUyeId.Size = new Size(0, 30);
			lblUyeId.TabIndex = 32;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(1229, 45);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(161, 150);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 31;
			pictureBox1.TabStop = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(469, 147);
			label5.Name = "label5";
			label5.Size = new Size(197, 48);
			label5.TabIndex = 30;
			label5.Text = "Üye Listesi";
			// 
			// dgwUyeler
			// 
			dgwUyeler.BackgroundColor = Color.Bisque;
			dgwUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwUyeler.ContextMenuStrip = cmsUyeler;
			dgwUyeler.Location = new Point(469, 201);
			dgwUyeler.MultiSelect = false;
			dgwUyeler.Name = "dgwUyeler";
			dgwUyeler.ReadOnly = true;
			dgwUyeler.RowHeadersWidth = 62;
			dgwUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgwUyeler.Size = new Size(931, 589);
			dgwUyeler.TabIndex = 29;
			// 
			// cmsUyeler
			// 
			cmsUyeler.ImageScalingSize = new Size(24, 24);
			cmsUyeler.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
			cmsUyeler.Name = "cmsUyeler";
			cmsUyeler.Size = new Size(151, 68);
			// 
			// silToolStripMenuItem
			// 
			silToolStripMenuItem.Name = "silToolStripMenuItem";
			silToolStripMenuItem.Size = new Size(150, 32);
			silToolStripMenuItem.Text = "Sil";
			silToolStripMenuItem.Click += silToolStripMenuItem_Click;
			// 
			// güncelleToolStripMenuItem
			// 
			güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
			güncelleToolStripMenuItem.Size = new Size(150, 32);
			güncelleToolStripMenuItem.Text = "Güncelle";
			güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
			// 
			// txtUyeSoyadi
			// 
			txtUyeSoyadi.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
			txtUyeSoyadi.Location = new Point(149, 194);
			txtUyeSoyadi.Name = "txtUyeSoyadi";
			txtUyeSoyadi.Size = new Size(266, 32);
			txtUyeSoyadi.TabIndex = 28;
			txtUyeSoyadi.KeyPress += txtUyeSoyadi_KeyPress;
			// 
			// txtUyeAdi
			// 
			txtUyeAdi.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
			txtUyeAdi.Location = new Point(149, 147);
			txtUyeAdi.Name = "txtUyeAdi";
			txtUyeAdi.Size = new Size(266, 32);
			txtUyeAdi.TabIndex = 27;
			txtUyeAdi.KeyPress += txtUyeAdi_KeyPress;
			// 
			// chkKadin
			// 
			chkKadin.AutoSize = true;
			chkKadin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			chkKadin.Location = new Point(293, 246);
			chkKadin.Name = "chkKadin";
			chkKadin.Size = new Size(106, 33);
			chkKadin.TabIndex = 26;
			chkKadin.Text = "Kadın";
			chkKadin.UseVisualStyleBackColor = true;
			// 
			// chkErkek
			// 
			chkErkek.AutoSize = true;
			chkErkek.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
			chkErkek.Location = new Point(152, 247);
			chkErkek.Name = "chkErkek";
			chkErkek.Size = new Size(106, 33);
			chkErkek.TabIndex = 25;
			chkErkek.Text = "Erkek";
			chkErkek.UseVisualStyleBackColor = true;
			// 
			// btnUyeGuncelle
			// 
			btnUyeGuncelle.BackColor = Color.MediumAquamarine;
			btnUyeGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnUyeGuncelle.Location = new Point(241, 322);
			btnUyeGuncelle.Name = "btnUyeGuncelle";
			btnUyeGuncelle.Size = new Size(168, 62);
			btnUyeGuncelle.TabIndex = 24;
			btnUyeGuncelle.Text = "GÜNCELLE";
			btnUyeGuncelle.UseVisualStyleBackColor = false;
			btnUyeGuncelle.Click += btnUyeGuncelle_Click;
			// 
			// btnUyeEkle
			// 
			btnUyeEkle.BackColor = Color.MediumAquamarine;
			btnUyeEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnUyeEkle.Location = new Point(21, 322);
			btnUyeEkle.Name = "btnUyeEkle";
			btnUyeEkle.Size = new Size(189, 62);
			btnUyeEkle.TabIndex = 23;
			btnUyeEkle.Text = "EKLE";
			btnUyeEkle.UseVisualStyleBackColor = false;
			btnUyeEkle.Click += btnUyeEkle_Click;
			// 
			// txtUyeNo
			// 
			txtUyeNo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
			txtUyeNo.Location = new Point(149, 102);
			txtUyeNo.Name = "txtUyeNo";
			txtUyeNo.Size = new Size(266, 32);
			txtUyeNo.TabIndex = 22;
			txtUyeNo.KeyPress += txtUyeNo_KeyPress;
			// 
			// lblCinsiyet
			// 
			lblCinsiyet.AutoSize = true;
			lblCinsiyet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblCinsiyet.Location = new Point(21, 247);
			lblCinsiyet.Name = "lblCinsiyet";
			lblCinsiyet.Size = new Size(125, 32);
			lblCinsiyet.TabIndex = 21;
			lblCinsiyet.Text = "CiNSİYET:";
			// 
			// lblSoyad
			// 
			lblSoyad.AutoSize = true;
			lblSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblSoyad.Location = new Point(24, 192);
			lblSoyad.Name = "lblSoyad";
			lblSoyad.Size = new Size(115, 32);
			lblSoyad.TabIndex = 20;
			lblSoyad.Text = "SOYADI :";
			// 
			// lblAd
			// 
			lblAd.AutoSize = true;
			lblAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblAd.Location = new Point(75, 147);
			lblAd.Name = "lblAd";
			lblAd.Size = new Size(63, 32);
			lblAd.TabIndex = 19;
			lblAd.Text = "AD :";
			// 
			// lblUyeNo
			// 
			lblUyeNo.AutoSize = true;
			lblUyeNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblUyeNo.Location = new Point(21, 100);
			lblUyeNo.Name = "lblUyeNo";
			lblUyeNo.Size = new Size(117, 32);
			lblUyeNo.TabIndex = 18;
			lblUyeNo.Text = "ÜYE NO :";
			// 
			// frmUyeIslemler
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(1405, 786);
			Controls.Add(grpUyeKayitFormu);
			Name = "frmUyeIslemler";
			Text = "ÜYE KAYIT İŞLEMLERİ FORMU";
			Load += frmUyeIslemler_Load;
			grpUyeKayitFormu.ResumeLayout(false);
			grpUyeKayitFormu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dgwUyeler).EndInit();
			cmsUyeler.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grpUyeKayitFormu;
		private TextBox txtUyeSoyadi;
		private TextBox txtUyeAdi;
		private CheckBox chkKadin;
		private CheckBox chkErkek;
		private Button btnUyeGuncelle;
		private Button btnUyeEkle;
		private TextBox txtUyeNo;
		private Label lblCinsiyet;
		private Label lblSoyad;
		private Label lblAd;
		private Label lblUyeNo;
		private PictureBox pictureBox1;
		private Label label5;
		private DataGridView dgwUyeler;
		private Label lblUyeId;
		private ContextMenuStrip cmsUyeler;
		private ToolStripMenuItem silToolStripMenuItem;
		private ToolStripMenuItem güncelleToolStripMenuItem;
	}
}