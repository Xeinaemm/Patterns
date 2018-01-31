using System.Collections.Generic;
using System.Linq;
using Patterns.Specification.Contracts;
using Patterns.Specification.Models;

namespace Patterns.Specification
{
	public class Util
	{
		private readonly IList<Course> _courses;

		public Util(IList<Course> courses) => _courses = courses;

		public IEnumerable<Course> JustUtil(ISpecification<Course> spec) => _courses.Where(spec.IsSatisfiedBy)
			.AsEnumerable();

		public IEnumerable<Course> JustUtil2(ISpecification<Course> spec) => _courses.Where(spec.CriteriaExpression.Compile())
			.AsEnumerable();
	}
}