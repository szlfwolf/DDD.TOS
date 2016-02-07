using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace DDD.TOS.Domain.Repositories
{
	public abstract class RepositoryContext : IRepositoryContext
	{
		private readonly ConcurrentDictionary<object, byte> newCollection = new ConcurrentDictionary<object, byte>();
		private readonly ConcurrentDictionary<object, byte> modifiedCollection = new ConcurrentDictionary<object, byte>();
		private readonly ConcurrentDictionary<object, byte> deletedCollection = new ConcurrentDictionary<object, byte>();
		private volatile bool commited = true;
		public Guid Id
		{
			get { throw new NotImplementedException(); }
		}

		public virtual void RegisterNew(object obj)
		{
			newCollection.AddOrUpdate(obj, byte.MinValue, (o, b) => byte.MinValue);
			commited = false;
		}

		public void RegisterModified(object obj)
		{
			if (deletedCollection.ContainsKey(obj))
			{
				throw new InvalidOperationException("The object cannot be registered as a modified object since it was marked as deleted.");
			}
			if(!modifiedCollection.ContainsKey(obj) && !newCollection.ContainsKey(obj))
			{
				modifiedCollection.AddOrUpdate(obj, byte.MinValue, (o, b) => byte.MinValue);
			}
			commited = false;
		}

		public void RegisterDeleted(object obj)
		{
			throw new NotImplementedException();
		}

		public abstract void Commit();


		public abstract void Rollback();		

		public Task CommitAsync()
		{
			throw new NotImplementedException();
		}

		public bool Commited
		{
			get { return this.commited; }
			protected set { this.commited = value; }
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
