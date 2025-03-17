using CSProjeDemo1.Data.Data;
using CSProjeDemo1.Entities.Entities;
using CSProjeDemo1.Entities.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSProjeDemo1.Presentation
{
	public partial class frmEmanetIslemler : Form
	{



		public frmEmanetIslemler()
		{
			InitializeComponent();
			
		}

		List<Uye> uyeler = new List<Uye>();
		List<Kitap> kitaplar = new List<Kitap>();
		List<EmanetIslem> emanetler = new List<EmanetIslem>();
		private void frmEmanetIslemler_Load(object sender, EventArgs e)
		{
		

			uyeler = DataBase.Uyeler.ToList();      // Veritabanından üyeleri al ve uyeler listesine ekle
			kitaplar = DataBase.Kitaplar.ToList(); // Veritabanından kitapları al ve kitaplar listesine ekle
			emanetler = DataBase.EmanetIslemler.ToList();

			dataGridViewUye.DataSource = uyeler; // DataGridView'e uyeler listesini ata
			dataGridViewKitap.DataSource = kitaplar;  // DataGridView'e kitaplar listesini ata
			dgwOduncList.DataSource = emanetler;
			dgwUyeAldigiKitaplar.DataSource = emanetler;


			// dataGridViewUye'deki Gerekli sütunları gizle
			dataGridViewUye.Columns[3].Visible = false;
			dataGridViewUye.Columns[5].Visible = false;
			dataGridViewUye.Columns[6].Visible = false;
			dataGridViewUye.Columns[7].Visible = false;
			dataGridViewUye.Columns[8].Visible = false;
			dataGridViewUye.Columns[9].Visible = false;


			//dataGridViewKitap'deki Gerekli sütunları gizle

			dataGridViewKitap.Columns[5].Visible = false;
			dataGridViewKitap.Columns[6].Visible = false;
			dataGridViewKitap.Columns[7].Visible = false;
			dataGridViewKitap.Columns[8].Visible = false;
			dataGridViewKitap.Columns[9].Visible = false;


			//dataGridViewOdunç'teki Gerekli sütunları gizle


			dgwOduncList.Columns[3].Visible = false;
			dgwOduncList.Columns[4].Visible = false;
			dgwOduncList.Columns[5].Visible = false;
			dgwOduncList.Columns[6].Visible = false;
			dgwOduncList.Columns[7].Visible = false;
			dgwOduncList.Columns[8].Visible = false;
			dgwOduncList.Columns[9].Visible = false;


			//dgwUyeAldigiKitaplar'daki Gerekli sütunları gizle


			//dgwUyeAldigiKitaplar.Columns[3].Visible = false;
			//dgwUyeAldigiKitaplar.Columns[4].Visible = false;
			dgwUyeAldigiKitaplar.Columns[5].Visible = false;
			dgwUyeAldigiKitaplar.Columns[6].Visible = false;
			dgwUyeAldigiKitaplar.Columns[7].Visible = false;
			dgwUyeAldigiKitaplar.Columns[8].Visible = false;
			dgwUyeAldigiKitaplar.Columns[9].Visible = false;



		}

		private void btnUyeAra_Click(object sender, EventArgs e)
		{
			string uyeArama = txtUyeArama.Text.Trim();

			var bulunanUyeler = uyeler.Where(u => u.Ad.Equals(uyeArama, StringComparison.OrdinalIgnoreCase)).ToList();

			if (bulunanUyeler.Any())
			{
				dataGridViewUye.DataSource = bulunanUyeler;
			}
			else
			{
				MessageBox.Show("Böyle bir üye sistemimizde yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		private void btnKitapAra_Click(object sender, EventArgs e)
		{
			string kitapArama = txtKitapArama.Text; 

			var bulunanKitaplar = kitaplar.Where(k => k.KitapAdi.Equals(kitapArama)).ToList(); 

			if (bulunanKitaplar.Any())
			{
				dataGridViewKitap.DataSource = bulunanKitaplar;
			}
			else
			{
				MessageBox.Show("Böyle bir kitap sistemimizde yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}



		private void btnOduncVer_Click(object sender, EventArgs e)
		{
			// Kişiyi aldık
			string secilenkisiAdi = txtUyeArama.Text;
			var secilenkisi = uyeler.Where(x => x.Ad.Equals(secilenkisiAdi, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

			// Kitabı aldık
			string secilenKitapAdi = txtKitapArama.Text;
			var secilenkitap = kitaplar.Where(x => x.KitapAdi.Equals(secilenKitapAdi, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

			// Üye ve kitap seçimi kontrolü
			if (secilenkisi == null && secilenkitap == null)
			{
				MessageBox.Show("Lütfen önce ödünç kitap verilecek üyeyi bulup, kitap seçimi yapıldıktan sonra Ödünç VER butonuna tıklayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; // Fonksiyondan çık
			}




			// Emanet kaydını oluştur
			EmanetIslem yeniKayit = new EmanetIslem
			{
				KitapId = secilenkitap.Id.ToString(), // ISBN veya benzersiz bir tanımlayıcı kullanılmalı
				UyeId = secilenkisi.Id.ToString(),
				VerilisTarihi = DateTime.Today,
				TeslimTarihi = DateTime.Today.AddDays(15),
				KitapDurum = KitapDurum.Oduncte // Kitap durumu ödünçte olarak ayarlandı
			};

			// Veritabanına kaydet
			DataBase.EmanetIslemler.Add(yeniKayit);
			//DataBase.SaveChanges(); // Bu satırı yorumdan çıkarın

			// dgwOduncList'e ekle
			var emanetList = DataBase.EmanetIslemler.ToList();
			dgwOduncList.DataSource = emanetList.ToList();

			MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUyeAldigiKitaplar_Click(object sender, EventArgs e)
		{

			string aranacakUye = txtUyeAldigiKitap.Text.Trim();

			var uyeVarMi = DataBase.Uyeler.Where(x => x.Ad.Equals(aranacakUye, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();



			if (uyeVarMi != null)
			{
				// Emanet işlemlerini üye ID'sine göre filtrele
				var emanetList = DataBase.EmanetIslemler
					.Where(x => x.UyeId == uyeVarMi.Id.ToString()) 
					.ToList();

				dgwUyeAldigiKitaplar.DataSource = emanetList;
			}
			else
			{
				MessageBox.Show("Böyle bir üye yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}




		}






	}
}
