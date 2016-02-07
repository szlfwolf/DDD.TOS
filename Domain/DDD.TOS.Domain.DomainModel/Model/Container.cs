using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.DomainModel
{
	public class Container : IAggregateRoot
    {
		public Guid ID
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public virtual ICollection<Workitem> WorkitemSet { get; set; }
	}
}
