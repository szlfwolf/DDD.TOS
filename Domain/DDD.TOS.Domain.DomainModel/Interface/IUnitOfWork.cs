using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.Interface
{
	public interface IUnitOfWork
	{
		void Commit();
		void Rollback();
		Task CommitAsync();
		bool Commited { get; }

	}
}
