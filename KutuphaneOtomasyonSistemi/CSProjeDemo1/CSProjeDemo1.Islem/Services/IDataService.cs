using CSProjeDemo1.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Islem.Services
{
   public  interface IDataService<T> where T : BaseEntity
    {
		bool Ekle(T model);
		bool Guncelle(T model);
		bool Sil(T model);
		List<T> HepsiniGetir();
		T Getir(Guid id);

	}
}
