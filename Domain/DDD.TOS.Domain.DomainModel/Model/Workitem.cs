using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.DomainModel
{
	public class Workitem	: IAggregateRoot
	{
		public Workitem()
		{
		}
		
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

		public Container ContainerInfo;
	}
}
