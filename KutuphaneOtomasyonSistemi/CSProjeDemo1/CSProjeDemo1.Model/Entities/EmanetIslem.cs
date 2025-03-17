using CSProjeDemo1.Entities.Base;
using CSProjeDemo1.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Entities
{
	public class EmanetIslem : BaseEntity
	{
		public DateTime VerilisTarihi { get; set; }

		public DateTime? TeslimTarihi { get; set; }

		public KitapDurum KitapDurum { get; set; }

		public string KitapId { get; set; }
		public string UyeId { get; set; }

	}
}
