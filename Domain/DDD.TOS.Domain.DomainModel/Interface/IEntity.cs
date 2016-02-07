using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain
{
	public interface IEntity: IEntity<Guid>
	{
	}
	public interface IEntity<TKey>
	{
		TKey ID { get; set; }
	}
}
