namespace CSProjeDemo1.Presentation
{
	partial class frmEmanetIslemler
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
			lblUyeAdiGir = new Label();
			txtUyeArama = new TextBox();
			dataGridViewUye = new DataGridView();
			btnUyeAra = new Button();
			lblBulunanUyeListesi = new Label();
			label2 = new Label();
			btnKitapAra = new Button();
			dataGridViewKitap = new DataGridView();
			label3 = new Label();
			grpUyeArama = new GroupBox();
			grpKitapArama = new GroupBox();
			txtKitapArama = new TextBox();
			grpOduncVer = new GroupBox();
			dgwOduncList = new DataGridView();
			btnOduncVer = new Button();
			grpUyeAldigiKitaplar = new GroupBox();
			label1 = new Label();
			txtUyeAldigiKitap = new TextBox();
			dgwUyeAldigiKitaplar = new DataGridView();
			btnUyeAldigiKitaplar = new Button();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewUye).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewKitap).BeginInit();
			grpUyeArama.SuspendLayout();
			grpKitapArama.SuspendLayout();
			grpOduncVer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgwOduncList).BeginInit();
			grpUyeAldigiKitaplar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgwUyeAldigiKitaplar).BeginInit();
			SuspendLayout();
			// 
			// lblUyeAdiGir
			// 
			lblUyeAdiGir.AutoSize = true;
			lblUyeAdiGir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			lblUyeAdiGir.Location = new Point(53, 44);
			lblUyeAdiGir.Name = "lblUyeAdiGir";
			lblUyeAdiGir.Size = new Size(174, 28);
			lblUyeAdiGir.TabIndex = 0;
			lblUyeAdiGir.Text = "ÜYE ADI GİRİNİZ:";
			// 
			// txtUyeArama
			// 
			txtUyeArama.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			txtUyeArama.Location = new Point(233, 44);
			txtUyeArama.Name = "txtUyeArama";
			txtUyeArama.Size = new Size(329, 34);
			txtUyeArama.TabIndex = 1;
			// 
			// dataGridViewUye
			// 
			dataGridViewUye.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewUye.Location = new Point(28, 140);
			dataGridViewUye.Name = "dataGridViewUye";
			dataGridViewUye.RowHeadersWidth = 62;
			dataGridViewUye.Size = new Size(672, 350);
			dataGridViewUye.TabIndex = 2;
			// 
			// btnUyeAra
			// 
			btnUyeAra.BackColor = Color.FromArgb(255, 255, 192);
			btnUyeAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			btnUyeAra.Location = new Point(568, 39);
			btnUyeAra.Name = "btnUyeAra";
			btnUyeAra.Size = new Size(132, 45);
			btnUyeAra.TabIndex = 3;
			btnUyeAra.Text = "ARA";
			btnUyeAra.UseVisualStyleBackColor = false;
			btnUyeAra.Click += btnUyeAra_Click;
			// 
			// lblBulunanUyeListesi
			// 
			lblBulunanUyeListesi.AutoSize = true;
			lblBulunanUyeListesi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblBulunanUyeListesi.Location = new Point(28, 107);
			lblBulunanUyeListesi.Name = "lblBulunanUyeListesi";
			lblBulunanUyeListesi.Size = new Size(123, 30);
			lblBulunanUyeListesi.TabIndex = 4;
			lblBulunanUyeListesi.Text = "Üye Listesi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label2.Location = new Point(27, 98);
			label2.Name = "label2";
			label2.Size = new Size(138, 30);
			label2.TabIndex = 9;
			label2.Text = "Kitap Listesi";
			// 
			// btnKitapAra
			// 
			btnKitapAra.BackColor = Color.FromArgb(255, 128, 128);
			btnKitapAra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			btnKitapAra.Location = new Point(568, 34);
			btnKitapAra.Name = "btnKitapAra";
			btnKitapAra.Size = new Size(132, 45);
			btnKitapAra.TabIndex = 8;
			btnKitapAra.Text = "ARA";
			btnKitapAra.UseVisualStyleBackColor = false;
			btnKitapAra.Click += btnKitapAra_Click;
			// 
			// dataGridViewKitap
			// 
			dataGridViewKitap.BackgroundColor = Color.Silver;
			dataGridViewKitap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewKitap.Location = new Point(27, 140);
			dataGridViewKitap.MultiSelect = false;
			dataGridViewKitap.Name = "dataGridViewKitap";
			dataGridViewKitap.ReadOnly = true;
			dataGridViewKitap.RowHeadersWidth = 62;
			dataGridViewKitap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewKitap.Size = new Size(904, 353);
			dataGridViewKitap.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			label3.Location = new Point(27, 39);
			label3.Name = "label3";
			label3.Size = new Size(193, 28);
			label3.TabIndex = 5;
			label3.Text = "KİTAP ADI GİRİNİZ:";
			// 
			// grpUyeArama
			// 
			grpUyeArama.BackColor = Color.LightSalmon;
			grpUyeArama.Controls.Add(lblUyeAdiGir);
			grpUyeArama.Controls.Add(txtUyeArama);
			grpUyeArama.Controls.Add(dataGridViewUye);
			grpUyeArama.Controls.Add(btnUyeAra);
			grpUyeArama.Controls.Add(lblBulunanUyeListesi);
			grpUyeArama.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			grpUyeArama.Location = new Point(12, 12);
			grpUyeArama.Name = "grpUyeArama";
			grpUyeArama.Size = new Size(779, 508);
			grpUyeArama.TabIndex = 10;
			grpUyeArama.TabStop = false;
			grpUyeArama.Text = "ÜYE ARAMA İŞLEMLERİ";
			// 
			// grpKitapArama
			// 
			grpKitapArama.BackColor = Color.FromArgb(128, 255, 128);
			grpKitapArama.Controls.Add(txtKitapArama);
			grpKitapArama.Controls.Add(label3);
			grpKitapArama.Controls.Add(label2);
			grpKitapArama.Controls.Add(dataGridViewKitap);
			grpKitapArama.Controls.Add(btnKitapAra);
			grpKitapArama.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			grpKitapArama.Location = new Point(797, 12);
			grpKitapArama.Name = "grpKitapArama";
			grpKitapArama.Size = new Size(974, 508);
			grpKitapArama.TabIndex = 11;
			grpKitapArama.TabStop = false;
			grpKitapArama.Text = "KİTAP ARAMA İŞLEMLERİ";
			// 
			// txtKitapArama
			// 
			txtKitapArama.Location = new Point(231, 36);
			txtKitapArama.Name = "txtKitapArama";
			txtKitapArama.Size = new Size(318, 37);
			txtKitapArama.TabIndex = 10;
			// 
			// grpOduncVer
			// 
			grpOduncVer.BackColor = Color.Yellow;
			grpOduncVer.Controls.Add(dgwOduncList);
			grpOduncVer.Controls.Add(btnOduncVer);
			grpOduncVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
			grpOduncVer.Location = new Point(12, 541);
			grpOduncVer.Name = "grpOduncVer";
			grpOduncVer.Size = new Size(779, 556);
			grpOduncVer.TabIndex = 12;
			grpOduncVer.TabStop = false;
			grpOduncVer.Text = "Ödünç Verme İşlemleri";
			// 
			// dgwOduncList
			// 
			dgwOduncList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwOduncList.Location = new Point(28, 179);
			dgwOduncList.Name = "dgwOduncList";
			dgwOduncList.RowHeadersWidth = 62;
			dgwOduncList.Size = new Size(672, 349);
			dgwOduncList.TabIndex = 1;
			// 
			// btnOduncVer
			// 
			btnOduncVer.BackColor = Color.Fuchsia;
			btnOduncVer.Location = new Point(28, 86);
			btnOduncVer.Name = "btnOduncVer";
			btnOduncVer.Size = new Size(202, 77);
			btnOduncVer.TabIndex = 0;
			btnOduncVer.Text = "Ödünç Ver";
			btnOduncVer.UseVisualStyleBackColor = false;
			btnOduncVer.Click += btnOduncVer_Click;
			// 
			// grpUyeAldigiKitaplar
			// 
			grpUyeAldigiKitaplar.BackColor = Color.FromArgb(255, 128, 255);
			grpUyeAldigiKitaplar.Controls.Add(label1);
			grpUyeAldigiKitaplar.Controls.Add(txtUyeAldigiKitap);
			grpUyeAldigiKitaplar.Controls.Add(dgwUyeAldigiKitaplar);
			grpUyeAldigiKitaplar.Controls.Add(btnUyeAldigiKitaplar);
			grpUyeAldigiKitaplar.Controls.Add(label4);
			grpUyeAldigiKitaplar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			grpUyeAldigiKitaplar.Location = new Point(797, 541);
			grpUyeAldigiKitaplar.Name = "grpUyeAldigiKitaplar";
			grpUyeAldigiKitaplar.Size = new Size(974, 570);
			grpUyeAldigiKitaplar.TabIndex = 13;
			grpUyeAldigiKitaplar.TabStop = false;
			grpUyeAldigiKitaplar.Text = "ÜYE ALDIĞI KİTAPLAR";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			label1.Location = new Point(55, 56);
			label1.Name = "label1";
			label1.Size = new Size(174, 28);
			label1.TabIndex = 5;
			label1.Text = "ÜYE ADI GİRİNİZ:";
			// 
			// txtUyeAldigiKitap
			// 
			txtUyeAldigiKitap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			txtUyeAldigiKitap.Location = new Point(235, 56);
			txtUyeAldigiKitap.Name = "txtUyeAldigiKitap";
			txtUyeAldigiKitap.Size = new Size(288, 34);
			txtUyeAldigiKitap.TabIndex = 6;
			// 
			// dgwUyeAldigiKitaplar
			// 
			dgwUyeAldigiKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgwUyeAldigiKitaplar.Location = new Point(17, 179);
			dgwUyeAldigiKitaplar.Name = "dgwUyeAldigiKitaplar";
			dgwUyeAldigiKitaplar.RowHeadersWidth = 62;
			dgwUyeAldigiKitaplar.Size = new Size(937, 377);
			dgwUyeAldigiKitaplar.TabIndex = 7;
			// 
			// btnUyeAldigiKitaplar
			// 
			btnUyeAldigiKitaplar.BackColor = Color.FromArgb(255, 255, 192);
			btnUyeAldigiKitaplar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			btnUyeAldigiKitaplar.Location = new Point(570, 51);
			btnUyeAldigiKitaplar.Name = "btnUyeAldigiKitaplar";
			btnUyeAldigiKitaplar.Size = new Size(91, 72);
			btnUyeAldigiKitaplar.TabIndex = 8;
			btnUyeAldigiKitaplar.Text = "ARA";
			btnUyeAldigiKitaplar.UseVisualStyleBackColor = false;
			btnUyeAldigiKitaplar.Click += btnUyeAldigiKitaplar_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
			label4.Location = new Point(17, 133);
			label4.Name = "label4";
			label4.Size = new Size(282, 30);
			label4.TabIndex = 9;
			label4.Text = "ALINAN KİTAPLAR LİSTESİ";
			// 
			// frmEmanetIslemler
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 192, 192);
			ClientSize = new Size(1783, 1278);
			Controls.Add(grpUyeAldigiKitaplar);
			Controls.Add(grpOduncVer);
			Controls.Add(grpKitapArama);
			Controls.Add(grpUyeArama);
			Name = "frmEmanetIslemler";
			Text = "frmEmanetIslemler";
			Load += frmEmanetIslemler_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewUye).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewKitap).EndInit();
			grpUyeArama.ResumeLayout(false);
			grpUyeArama.PerformLayout();
			grpKitapArama.ResumeLayout(false);
			grpKitapArama.PerformLayout();
			grpOduncVer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgwOduncList).EndInit();
			grpUyeAldigiKitaplar.ResumeLayout(false);
			grpUyeAldigiKitaplar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgwUyeAldigiKitaplar).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Label lblUyeAdiGir;
		private TextBox txtUyeArama;
		private DataGridView dataGridViewUye;
		private Button btnUyeAra;
		private Label lblBulunanUyeListesi;
		private Label label2;
		private Button btnKitapAra;
		private DataGridView dataGridViewKitap;
		private Label label3;
		private GroupBox grpUyeArama;
		private GroupBox grpKitapArama;
		private GroupBox grpOduncVer;
		private DataGridView dgwOduncList;
		private Button btnOduncVer;
		private GroupBox grpUyeAldigiKitaplar;
		private Label label1;
		private TextBox txtUyeAldigiKitap;
		private DataGridView dgwUyeAldigiKitaplar;
		private Button btnUyeAldigiKitaplar;
		private Label label4;
		private TextBox txtKitapArama;
	}
}