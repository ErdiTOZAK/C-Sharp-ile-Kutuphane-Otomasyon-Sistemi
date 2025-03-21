﻿using CSProjeDemo1.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entities.Base
{
	public abstract class BaseEntity 
	{
		public Guid Id { get; set; }

		public Status Status { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
	}
}
