using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.Repositories
{
	public interface IRepository<TKey, TAggregateRoot> where TAggregateRoot : class,IAggregateRoot<TKey>
	{
		void Add(TAggregateRoot aggregateRoot);
		void Update(TAggregateRoot aggregateRoot);
		void Remove(TAggregateRoot aggregateRoot);
	}

	public interface IRepository<TAggregateRoot> : IRepository<Guid, TAggregateRoot> where TAggregateRoot : class,IAggregateRoot<Guid>
	{
	}
}
