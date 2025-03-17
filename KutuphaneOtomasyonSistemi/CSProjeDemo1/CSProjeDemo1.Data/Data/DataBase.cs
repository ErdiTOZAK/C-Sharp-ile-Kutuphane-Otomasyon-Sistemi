using CSProjeDemo1.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Data.Data
{
   public static  class DataBase
    {

		public static List<Kitap> Kitaplar { get; set; } = new List<Kitap>();


		public static List<Uye> Uyeler { get; set; } = new List<Uye>();

		public static List<EmanetIslem> EmanetIslemler { get; set; } = new List<EmanetIslem>();




	}
}
