using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDD.TOS.Domain
{
	public interface IAggregateRoot<TKey> : IEntity<TKey>
	{
	}
	public interface IAggregateRoot : IAggregateRoot<Guid>, IEntity
	{

	}
}
