using CSProjeDemo1.Data.Data;
using CSProjeDemo1.Entities.Entities;
using CSProjeDemo1.Islem.Services;
using CSProjeDemo1.Presentation.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSProjeDemo1.Presentation
{
	public partial class frmUyeIslemler : Form
	{
		public frmUyeIslemler()
		{
			InitializeComponent();

			Uye uye = new Uye()
			{
				UyeNo="1",
				Ad = "Orhan",
				Soyad = "Pamuk",
				Cinsiyet = true,
				Id = Guid.NewGuid(),
			};
			Uye uye1 = new Uye()
			{
				UyeNo = "2",
				Ad = "Reşat Nuri",
				Soyad = "Güntekin",
				Cinsiyet = true,
				Id = Guid.NewGuid(),
			};
			Uye uye2 = new Uye()
			{
				UyeNo = "3",
				Ad = "Yahya",
				Soyad = "Kemal",
				Cinsiyet = true,
				Id = Guid.NewGuid(),
			};
			Uye uye3 = new Uye()
			{
				UyeNo = "4",
				Ad = "Ayşe",
				Soyad = "Kulin",
				Cinsiyet = false,
				Id = Guid.NewGuid(),
			};

			DataBase.Uyeler.Add(uye);
			DataBase.Uyeler.Add(uye1);
			DataBase.Uyeler.Add(uye2);
			DataBase.Uyeler.Add(uye3);
			

			dgwUyeler.DataSource = DataBase.Uyeler.ToList();



			//dataGridViewKitap'deki Gerekli sütunları gizle

			dgwUyeler.Columns[5].Visible = false;
			dgwUyeler.Columns[6].Visible = false;
			dgwUyeler.Columns[7].Visible = false;
			dgwUyeler.Columns[8].Visible = false;
			dgwUyeler.Columns[9].Visible = false;
		}

		DataService<Uye> uyeDataService = new DataService<Uye>();




		private void ResetTable()
		{
			dgwUyeler.DataSource = null;

			var uyeler = uyeDataService.HepsiniGetir();
			List<UyeListVM> list = new List<UyeListVM>();

			foreach (var uye in uyeler)
			{
				UyeListVM uyeListVM = new UyeListVM()
				{
					Id = uye.Id,
					UyeNo = uye.UyeNo,
					Ad = uye.Ad,
					Soyad = uye.Soyad,
					Cinsiyet = uye.Cinsiyet,

				};
				list.Add(uyeListVM);
			}
			dgwUyeler.DataSource = list;
			dgwUyeler.Columns["Id"].Visible = false;
			Clean();
		}

		private void Clean()
		{
			txtUyeNo.Text = string.Empty;
			txtUyeAdi.Text = string.Empty;
			txtUyeSoyadi.Text = string.Empty;
			chkErkek.Checked = false;
			chkKadin.Checked = false;

		}

		private Guid SelectId()
		{
			var id = dgwUyeler.Rows[dgwUyeler.SelectedCells[0].RowIndex].Cells["Id"].Value;
			lblUyeId.Text = id.ToString();
			return (Guid)id;

		}


		private void frmUyeIslemler_Load(object sender, EventArgs e)
		{
			btnUyeGuncelle.Enabled = false;
			ResetTable();



		}


		private void btnUyeEkle_Click(object sender, EventArgs e)
		{
			// Boş alanları kontrol et
			List<string> bosAlanlar = new List<string>();

			if (string.IsNullOrWhiteSpace(txtUyeNo.Text))
			{
				bosAlanlar.Add("Üye No");
			}

			if (string.IsNullOrWhiteSpace(txtUyeAdi.Text))
			{
				bosAlanlar.Add("Ad");
			}

			if (string.IsNullOrWhiteSpace(txtUyeSoyadi.Text))
			{
				bosAlanlar.Add("Soyad");
			}

			// Eğer boş alan varsa kullanıcıya bir mesaj göster
			if (bosAlanlar.Count > 0)
			{
				string alanlar = string.Join(", ", bosAlanlar);
				MessageBox.Show($"{alanlar} alan(lar)ı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Cinsiyet kontrolü
			if (!chkErkek.Checked && !chkKadin.Checked)
			{
				MessageBox.Show("Lütfen Cinsiyet alanı için 'Erkek' veya 'Kız' seçeneğinden birini işaretleyiniz!.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Uye eklenecekUye = new Uye()
			{
				Id = Guid.NewGuid(),
				UyeNo = txtUyeNo.Text,
				Ad = txtUyeAdi.Text,
				Soyad = txtUyeSoyadi.Text,
				Cinsiyet = chkErkek.Checked 
			};

			uyeDataService.Ekle(eklenecekUye);
			var result = uyeDataService.HepsiniGetir();

			ResetTable();
		}


		private void btnUyeGuncelle_Click(object sender, EventArgs e)
		{
			Uye uye = new Uye()
			{
				UyeNo = txtUyeNo.Text,
				Ad = txtUyeAdi.Text,
				Soyad = txtUyeSoyadi.Text,
				Cinsiyet = chkErkek.Checked ? true : false,
				Id = Guid.Parse(lblUyeId.Text)
			};
			uyeDataService.Guncelle(uye);
			ResetTable();

			// Güncelleme mesajı
			MessageBox.Show("Üye bilgileri başarıyla güncellendi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dgwUyeler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var secilenId = dgwUyeler.Rows[dgwUyeler.SelectedCells[0].RowIndex].Cells[4].Value.ToString();


		}

		private void txtUyeNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Sayı dışında bir karakter girildiğinde
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true; // Girişi engelle
				MessageBox.Show("Lütfen sadece sayı giriniz!.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txtUyeAdi_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Eğer basılan tuş bir kontrol karakteri (örneğin: Backspace) değilse
			// ve basılan tuş bir harf değilse
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
			{
				// Geçerli bir karakter değil, olayın iptal edilmesi gerekiyor.
				e.Handled = true;
				// Uyarı mesajı göster.
				MessageBox.Show("Lütfen Ad alanı için sadece harfleri kullanınız!.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txtUyeSoyadi_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Eğer basılan tuş bir kontrol karakteri (örneğin: Backspace) değilse
			// ve basılan tuş bir harf değilse
			if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
			{
				// Geçerli bir karakter değil, olayın iptal edilmesi gerekiyor.
				e.Handled = true;
				// Uyarı mesajı göster.
				MessageBox.Show("Lütfen Soyad alanı için sadece harfleri kullanınız!.", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var deletingUye = uyeDataService.Getir(SelectId());

			// Kullanıcıya onay mesajını göster
			var dialogResult = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			// Eğer kullanıcı "Hayır" butonuna bastıysa, işlemi iptal et
			if (dialogResult == DialogResult.No)
			{
				return; // İşlem iptal edilir, silme işlemi yapılmaz
			}

			// Kullanıcı "Evet" butonuna bastıysa, silme işlemini gerçekleştir
			var result = uyeDataService.Sil(deletingUye);

			if (result)
			{
				MessageBox.Show("Kayıt başarıyla silindi.");
			}
			else
			{
				MessageBox.Show("Hatalı silme işlemi.");
			}

			ResetTable();

			var res = uyeDataService.HepsiniGetir();
			var res2 = Data.Data.DataBase.Uyeler;
		}

		private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var updateUye = uyeDataService.Getir(SelectId());
			txtUyeNo.Text = updateUye.UyeNo;
			txtUyeAdi.Text = updateUye.Ad;
			txtUyeSoyadi.Text = updateUye.Soyad;
			chkErkek.Checked = updateUye.Cinsiyet ? true : false;
			chkKadin.Checked = updateUye.Cinsiyet ? false : true;

			btnUyeGuncelle.Enabled = true;

			
		}
	}
}
