using CSProjeDemo1.Data.Data;
using CSProjeDemo1.Entities.Base;
using CSProjeDemo1.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Islem.Services
{
	public class DataService<T> : IDataService<T> where T : BaseEntity

	{
		public bool Ekle(T model)
		{
			model.CreatedDate = DateTime.Now;
			model.Id = Guid.NewGuid();
			model.Status = Entities.Enum.Status.Create;

			if (model is Uye uye)
			{
				DataBase.Uyeler.Add(uye);
				return true;

			}
			else if (model is Kitap kitap)
			{
				DataBase.Kitaplar.Add(kitap);
				return true;
			}


			else if (model is EmanetIslem emanetIslem)
			{
				DataBase.EmanetIslemler.Add(emanetIslem);
				return true;
			}

			else { return false; }
		}


		public T Getir(Guid id)
		{
			if (typeof(T) == typeof(Uye))
			{
				return DataBase.Uyeler.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Entities.Enum.Status.Delete);
			}
			else if (typeof(T) == typeof(Kitap))
			{
				return DataBase.Kitaplar.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Entities.Enum.Status.Delete);
			}


			else if (typeof(T) == typeof(EmanetIslem))
			{
				return DataBase.EmanetIslemler.OfType<T>().ToList().FirstOrDefault(x => x.Id == id && x.Status != Entities.Enum.Status.Delete);
			}

			else
			{
				return null;
			}
		}

		public bool Guncelle(T model)
		{
			model.ModifiedDate = DateTime.Now;

			model.Status = Entities.Enum.Status.Update;

			if (model is Uye uye)
			{
				var updateUye = DataBase.Uyeler.FirstOrDefault(x => x.Id == uye.Id);
				uye.CreatedDate = updateUye.CreatedDate;
				var index = DataBase.Uyeler.IndexOf(updateUye);
				DataBase.Uyeler[index] = uye;
				return true;
			}
			else if (model is Kitap kitap)
			{
				var updateKitap = DataBase.Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);

				kitap.CreatedDate = updateKitap.CreatedDate;
				var index = DataBase.Kitaplar.IndexOf(updateKitap);
				DataBase.Kitaplar[index] = kitap;
				return true;
			}


			else if (model is EmanetIslem emanetIslem)
			{
				var updateEmanetIslem = DataBase.EmanetIslemler.FirstOrDefault(x => x.Id == emanetIslem.Id);

				emanetIslem.CreatedDate = updateEmanetIslem.CreatedDate;
				var index = DataBase.EmanetIslemler.IndexOf(updateEmanetIslem);
				DataBase.EmanetIslemler[index] = emanetIslem;
				return true;
			}

			else { return false; }
		}


		public List<T> HepsiniGetir()
		{
			if (typeof(T) == typeof(Uye))
			{
				return DataBase.Uyeler.OfType<T>().Where(x => x.Status != Entities.Enum.Status.Delete).ToList();
			}
			else if (typeof(T) == typeof(Kitap))
			{
				return DataBase.Kitaplar.OfType<T>().Where(x => x.Status != Entities.Enum.Status.Delete).ToList();
			}


			else if (typeof(T) == typeof(EmanetIslem))
			{
				return DataBase.EmanetIslemler.OfType<T>().Where(x => x.Status != Entities.Enum.Status.Delete).ToList();
			}

			else
			{
				return null;
			}
		}

		public bool Sil(T model)
		{
			model.DeletedDate = DateTime.Now;

			model.Status = Entities.Enum.Status.Delete;

			if (model is Uye uye)
			{
				var updateUye = DataBase.Uyeler.FirstOrDefault(x => x.Id == uye.Id);
				var index = DataBase.Uyeler.IndexOf(updateUye);
				DataBase.Uyeler[index] = uye;
				return true;
			}
			else if (model is Kitap kitap)
			{
				var updateKitap = DataBase.Kitaplar.FirstOrDefault(x => x.Id == kitap.Id);
				var index = DataBase.Kitaplar.IndexOf(updateKitap);
				DataBase.Kitaplar[index] = kitap;
				return true;
			}


			else if (model is EmanetIslem emanetIslem)
			{
				var updateEmanetIslem = DataBase.EmanetIslemler.FirstOrDefault(x => x.Id == emanetIslem.Id);

				var index = DataBase.EmanetIslemler.IndexOf(updateEmanetIslem);
				DataBase.EmanetIslemler[index] = emanetIslem;
				return true;
			}

			else { return false; }
		}

	}

}
