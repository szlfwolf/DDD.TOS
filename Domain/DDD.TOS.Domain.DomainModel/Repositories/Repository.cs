using DDD.TOS.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.Repositories
{
	public abstract class Repository<TKey,TAggregateRoot> : IRepository<TKey,TAggregateRoot> where TAggregateRoot: class, IAggregateRoot<TKey>
	{
		private IRepositoryContext context;
		public Repository(IRepositoryContext context)
		{
			this.context = context;
		}

		public void Add(TAggregateRoot aggregateRoot)
		{
			this.DoAdd(aggregateRoot);
		}

		protected abstract void DoAdd(TAggregateRoot aggregateRoot);		

		public void Update(TAggregateRoot aggregateRoot)
		{
			this.DoUpdate(aggregateRoot);
		}
		protected abstract void DoUpdate(TAggregateRoot aggregateRoot);

		public void Remove(TAggregateRoot aggregateRoot)
		{
			throw new NotImplementedException();
		}
	}
}
