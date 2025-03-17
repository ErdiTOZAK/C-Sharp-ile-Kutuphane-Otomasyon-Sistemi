using CSProjeDemo1.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Entities
{
	public class Uye : BaseEntity
	{
		public string UyeNo { get; set; }

		public string? Ad { get; set; }

		public string? Soyad { get; set; }

		public string FulLAd
		{
			get
			{ return Ad + " " + Soyad; }

			set {; }
		}

		public bool Cinsiyet { get; set; }
	}
}
