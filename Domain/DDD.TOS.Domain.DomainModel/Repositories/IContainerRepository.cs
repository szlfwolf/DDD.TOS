using DDD.TOS.Domain.DomainModel;
using DDD.TOS.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.TOS.Domain.Repositories
{
	interface IContainerRepository : IRepository<Container>
	{
		/// <summary>
		/// 海关锁定
		/// </summary>
		bool CustomLocked { get; set; }
	}
}
