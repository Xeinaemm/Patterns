using System;
using System.Linq.Expressions;
using Patterns.Specification.Contracts;
using Patterns.Specification.Models;

namespace Patterns.Specification.Implementation
{
	public class Validator : ISpecification<Course>
	{
		public Expression<Func<Course, bool>> CriteriaExpression
		{
			get { return x => x.Count > 0; }
		}

		public bool IsSatisfiedBy(Course target)
		{
			if (target.Count == 0) return false;
			return true;
		}
	}
}