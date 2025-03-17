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

namespace CSProjeDemo1.Presentation
{
	public partial class frmKitapIslemler : Form
	{
		public frmKitapIslemler()
		{
			InitializeComponent();

			Kitap kitap = new Kitap()
			{
				ISBN = "975-17-1627-6",
				KitapAdi = "ÇALIKUŞU",
				Tur = "ROMAN",
				YazarAdSoyad = "REŞAT NURİ GÜNTEKİN",
				BasimYili = dtpBasimYili.Value.AddDays(6),
				//Id = Guid.NewGuid(),

			};

			Kitap kitap1 = new Kitap()
			{
				ISBN = "175-17-1627-7",
				KitapAdi = "MAİ VE SİYAH",
				Tur = "ROMAN",
				YazarAdSoyad = "HALİDE EDİP ADIVAR",
				BasimYili = dtpBasimYili.Value.AddDays(5),
				//Id = Guid.NewGuid(),

			};
			Kitap kitap2 = new Kitap()
			{
				ISBN = "275-17-1627-8",
				KitapAdi = "SEVDALİNKA",
				Tur = "MACERA",
				YazarAdSoyad = "AYŞE KULİN",
				BasimYili = dtpBasimYili.Value.AddDays(3),
				//Id = Guid.NewGuid(),
			};

			DataBase.Kitaplar.Add(kitap);
			DataBase.Kitaplar.Add(kitap1);
			DataBase.Kitaplar.Add(kitap2);

			dgwKitaplar.DataSource = DataBase.Kitaplar.ToList();



			//dataGridViewKitap'deki Gerekli sütunları gizle

			dgwKitaplar.Columns[5].Visible = false;
			dgwKitaplar.Columns[6].Visible = false;
			dgwKitaplar.Columns[7].Visible = false;
			dgwKitaplar.Columns[8].Visible = false;
			dgwKitaplar.Columns[9].Visible = false;
		}

		DataService<Kitap> kitapDataService = new DataService<Kitap>();


		private void ResetTable()
		{
			dgwKitaplar.DataSource = null;

			var kitaplar = kitapDataService.HepsiniGetir();
			List<KitapListVM> list = new List<KitapListVM>();

			foreach (var kitap in kitaplar)
			{
				KitapListVM kitapListVM = new KitapListVM()
				{

					Id = kitap.Id,
					ISBN = kitap.ISBN,
					KitapAdi = kitap.KitapAdi,
					BasimYili = kitap.BasimYili,
					Tur = kitap.Tur,
					YazarAdSoyad = kitap.YazarAdSoyad


				};
				list.Add(kitapListVM);
			}
			dgwKitaplar.DataSource = list;
			dgwKitaplar.Columns["Id"].Visible = false;
			Clean();
		}
		private void Clean()
		{
			txtKitapISBN.Text = string.Empty;
			txtKitapAdi.Text = string.Empty;
			txtKitapTur.Text = string.Empty;
			txtYazarAdSoyad.Text = string.Empty;



		}
		private Guid SelectId()
		{
			var id = dgwKitaplar.Rows[dgwKitaplar.SelectedCells[0].RowIndex].Cells["Id"].Value;
			lblKitapId.Text = id.ToString();
			return (Guid)id;

		}

		private void btnKitapEkle_Click(object sender, EventArgs e)
		{
			Kitap eklenecekKitap = new Kitap()
			{
				Id = Guid.NewGuid(),
				ISBN = txtKitapISBN.Text,
				KitapAdi = txtKitapAdi.Text,
				Tur = txtKitapTur.Text,
				YazarAdSoyad = txtYazarAdSoyad.Text,
				BasimYili = dtpBasimYili.Value

			};
			kitapDataService.Ekle(eklenecekKitap);
			var result = kitapDataService.HepsiniGetir();

			ResetTable();
		}



		private void btnKitapGuncelle_Click(object sender, EventArgs e)
		{
			Kitap kitap = new Kitap()
			{

				ISBN = txtKitapISBN.Text,
				KitapAdi = txtKitapAdi.Text,
				Tur = txtKitapTur.Text,
				YazarAdSoyad = txtYazarAdSoyad.Text,
				Id = Guid.Parse(lblKitapId.Text)
			};
			kitapDataService.Guncelle(kitap);
			ResetTable();
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var deletingKitap = kitapDataService.Getir(SelectId());
			var result = kitapDataService.Sil(deletingKitap);
			if (result)
			{
				MessageBox.Show("Silme İşlemi Başarılı");
			}
			else
			{
				MessageBox.Show("Hatalı Silme İşlemi");
			}
			ResetTable();

			var res = kitapDataService.HepsiniGetir();
			var res2 = Data.Data.DataBase.Kitaplar;
		}

		private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var updateKitap = kitapDataService.Getir(SelectId());
			txtKitapISBN.Text = updateKitap.ISBN;
			txtKitapTur.Text = updateKitap.Tur;
			txtKitapAdi.Text = updateKitap.KitapAdi;
			txtYazarAdSoyad.Text = updateKitap.YazarAdSoyad;


			btnKitapGuncelle.Enabled = true;
		}
	}
}
