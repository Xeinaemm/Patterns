using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using Patterns.Repository.RepoWithUnityOfWork.Contracts;

namespace Patterns.Repository.RepoWithUnityOfWork.Implementations
{
	public class SqlRepository<T> : IRepository<T> where T : class, IEntity
	{
		protected ObjectSet<T> _objectSet;

		public SqlRepository(ObjectContext context) => _objectSet = context.CreateObjectSet<T>();

		public IQueryable<T> FindAll() => _objectSet;

		public IQueryable<T> Find(Expression<Func<T, bool>> predicate) => _objectSet.Where(predicate);

		public T Find(int id)
		{
			return _objectSet.Single(x => x.Id == id);
		}

		public void Add(T newEntity)
		{
			_objectSet.AddObject(newEntity);
		}

		public void Remove(T entity)
		{
			_objectSet.DeleteObject(entity);
		}
	}
}