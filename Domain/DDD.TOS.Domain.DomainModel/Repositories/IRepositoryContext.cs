using DDD.TOS.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.Repositories
{
	public interface IRepositoryContext: IUnitOfWork, IDisposable
	{
		Guid Id { get; }
		void RegisterNew(object obj);
		void RegisterModified(object obj);
		void RegisterDeleted(object obj);
	}
}
