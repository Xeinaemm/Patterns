using System;
using System.Linq.Expressions;

namespace Patterns.Specification.Contracts
{
	public interface ISpecification<T>
	{
		Expression<Func<T, bool>> CriteriaExpression { get; }
		bool IsSatisfiedBy(T target);
	}
}