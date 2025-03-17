using CSProjeDemo1.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Entities
{
    
		public class Kitap : BaseEntity
		{
			public string ISBN { get; set; } = null!;

			public string KitapAdi { get; set; } = null!;

			public string Tur { get; set; }

			public string YazarAdSoyad { get; set; }

			public DateTime BasimYili { get; set; }
		}
	
}
