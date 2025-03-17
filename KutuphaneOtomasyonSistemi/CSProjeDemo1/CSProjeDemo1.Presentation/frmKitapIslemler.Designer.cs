namespace CSProjeDemo1.Presentation
{
	partial class frmKitapIslemler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapIslemler));
			dtpBasimYili = new DateTimePicker();
			lblKitapId = new Label();
			txtYazarAdSoyad = new TextBox();
			label5 = new Label();
			btnKitapGuncelle = new Button();
			btnKitapEkle = new Button();
			label4 = new Label();
			txtKitapTur = new TextBox();
			txtKitapAdi = new TextBox();
			txtKitapISBN = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			dgwKitaplar = new DataGridView();
			label6 = new Label();
			cmsKitaplar = new ContextMenuStrip(components);
			silToolStripMenuItem = new ToolStripMenuItem();
			güncelleToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dgwKitaplar).BeginInit();
			cmsKitaplar.SuspendLayout();
			SuspendLayout();
			// 
			// dtpBasimYili
			// 
			dtpBasimYili.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			dtpBasimYili.Format = DateTimePickerFormat.Custom;
			dtpBasimYili.Location = new Point(205, 271);
			dtpBasimYili.Name = "dtpBasimYili";
			dtpBasimYili.Size = new Size(251, 39);
			dtpBasimYili.TabIndex = 29;
			// 
			// lblKitapId
			// 
			lblKitapId.AutoSize = true;
			lblKitapId.Location = new Point(536, 285);
			lblKitapId.Name = "lblKitapId";
			lblKitapId.Size = new Size(0, 25);
			lblKitapId.TabIndex = 28;
			// 
			// txtYazarAdSoyad
			// 
			txtYazarAdSoyad.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			txtYazarAdSoyad.Location = new Point(196, 211);
			txtYazarAdSoyad.Name = "txtYazarAdSoyad";
			txtYazarAdSoyad.Size = new Size(260, 39);
			txtYazarAdSoyad.TabIndex = 27;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			label5.Location = new Point(76, 163);
			label5.Name = "label5";
			label5.Size = new Size(85, 32);
			label5.TabIndex = 26;
			label5.Text = "Türü:";
			// 
			// btnKitapGuncelle
			// 
			btnKitapGuncelle.BackColor = Color.Yellow;
			btnKitapGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnKitapGuncelle.Location = new Point(529, 173);
			btnKitapGuncelle.Name = "btnKitapGuncelle";
			btnKitapGuncelle.Size = new Size(231, 52);
			btnKitapGuncelle.TabIndex = 25;
			btnKitapGuncelle.Text = "GÜNCELLE";
			btnKitapGuncelle.UseVisualStyleBackColor = false;
			// 
			// btnKitapEkle
			// 
			btnKitapEkle.BackColor = Color.Yellow;
			btnKitapEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			btnKitapEkle.Location = new Point(529, 94);
			btnKitapEkle.Name = "btnKitapEkle";
			btnKitapEkle.Size = new Size(231, 55);
			btnKitapEkle.TabIndex = 24;
			btnKitapEkle.Text = "EKLE";
			btnKitapEkle.UseVisualStyleBackColor = false;
			btnKitapEkle.Click += btnKitapEkle_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			label4.Location = new Point(28, 279);
			label4.Name = "label4";
			label4.Size = new Size(159, 32);
			label4.TabIndex = 23;
			label4.Text = "Basım Yılı:";
			// 
			// txtKitapTur
			// 
			txtKitapTur.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			txtKitapTur.Location = new Point(196, 154);
			txtKitapTur.Name = "txtKitapTur";
			txtKitapTur.Size = new Size(260, 39);
			txtKitapTur.TabIndex = 22;
			// 
			// txtKitapAdi
			// 
			txtKitapAdi.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			txtKitapAdi.Location = new Point(196, 94);
			txtKitapAdi.Name = "txtKitapAdi";
			txtKitapAdi.Size = new Size(260, 39);
			txtKitapAdi.TabIndex = 21;
			// 
			// txtKitapISBN
			// 
			txtKitapISBN.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			txtKitapISBN.Location = new Point(196, 33);
			txtKitapISBN.Name = "txtKitapISBN";
			txtKitapISBN.Size = new Size(260, 39);
			txtKitapISBN.TabIndex = 20;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			label3.Location = new Point(55, 214);
			label3.Name = "label3";
			label3.Size = new Size(110, 32);
			label3.TabIndex = 19;
			label3.Text = "Yazarı:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			label2.Location = new Point(21, 101);
			label2.Name = "label2";
			label2.Size = new Size(155, 32);
			label2.TabIndex = 18;
			label2.Text = "Kitap Adı :";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
			label1.Location = new Point(55, 36);
			label1.Name = "label1";
			label1.Size = new Size(100, 32);
			label1.TabIndex = 17;
			label1.Text = "ISBN :";
			// 
			// dgwKitaplar
			// 
			dgwKitaplar.BackgroundColor = Color.FromArgb(192, 192, 255);
			dgwKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwKitaplar.ContextMenuStrip = cmsKitaplar;
			dgwKitaplar.Location = new Point(-11, 397);
			dgwKitaplar.MultiSelect = false;
			dgwKitaplar.Name = "dgwKitaplar";
			dgwKitaplar.ReadOnly = true;
			dgwKitaplar.RowHeadersWidth = 62;
			dgwKitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgwKitaplar.Size = new Size(1423, 435);
			dgwKitaplar.TabIndex = 30;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label6.Location = new Point(12, 346);
			label6.Name = "label6";
			label6.Size = new Size(249, 48);
			label6.TabIndex = 31;
			label6.Text = "KİTAP LİSTESİ";
			// 
			// cmsKitaplar
			// 
			cmsKitaplar.ImageScalingSize = new Size(24, 24);
			cmsKitaplar.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem });
			cmsKitaplar.Name = "cmsKitaplar";
			cmsKitaplar.Size = new Size(151, 68);
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
			// frmKitapIslemler
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.None;
			ClientSize = new Size(1411, 827);
			Controls.Add(label6);
			Controls.Add(dgwKitaplar);
			Controls.Add(dtpBasimYili);
			Controls.Add(lblKitapId);
			Controls.Add(txtYazarAdSoyad);
			Controls.Add(label5);
			Controls.Add(btnKitapGuncelle);
			Controls.Add(btnKitapEkle);
			Controls.Add(label4);
			Controls.Add(txtKitapTur);
			Controls.Add(txtKitapAdi);
			Controls.Add(txtKitapISBN);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "frmKitapIslemler";
			Text = "KİTAP İŞLEMLERİ FORMU";
			((System.ComponentModel.ISupportInitialize)dgwKitaplar).EndInit();
			cmsKitaplar.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dtpBasimYili;
		private Label lblKitapId;
		private TextBox txtYazarAdSoyad;
		private Label label5;
		private Button btnKitapGuncelle;
		private Button btnKitapEkle;
		private Label label4;
		private TextBox txtKitapTur;
		private TextBox txtKitapAdi;
		private TextBox txtKitapISBN;
		private Label label3;
		private Label label2;
		private Label label1;
		private DataGridView dgwKitaplar;
		private Label label6;
		private ContextMenuStrip cmsKitaplar;
		private ToolStripMenuItem silToolStripMenuItem;
		private ToolStripMenuItem güncelleToolStripMenuItem;
	}
}