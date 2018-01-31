using System;
using System.Linq;
using System.Linq.Expressions;

namespace Patterns.State.Contracts
{
	public interface IRepository<T> where T : class, IEntity
	{
		IQueryable<T> FindAll();
		IQueryable<T> Find(Expression<Func<T, bool>> predicate);
		T Find(int id);
		void Add(T newEntity);
		void Remove(T entity);
	}
}