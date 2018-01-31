using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Patterns.State.Contracts;

namespace Patterns.State.Implementation
{
	public class XmlRepository<T> : IRepository<T> where T : class, IEntity
	{
		protected List<T> DataList;

		public XmlRepository() => DataList = new List<T>();

		public IQueryable<T> FindAll() => DataList.AsQueryable();

		public IQueryable<T> Find(Expression<Func<T, bool>> predicate) => DataList.AsQueryable()
			.Where(predicate);

		public T Find(int id)
		{
			return DataList.Find(x => x.Id == id);
		}

		public void Add(T newEntity)
		{
			var maxId = 0;
			if (DataList.Any())
				maxId = DataList.AsQueryable()
					.Max(x => x.Id);
			newEntity.Id = maxId + 1;
			DataList.Add(newEntity);
		}

		public void Remove(T entity)
		{
			var x = Find(entity.Id);
			DataList.Remove(x);
		}
	}
}