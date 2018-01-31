using System.Configuration;
using System.Data.Entity.Core.Objects;
using Patterns.UnityOfWork.Contracts;
using Patterns.UnityOfWork.Entities;

namespace Patterns.UnityOfWork.Implementations
{
	public class SqlUnityOfWork : IUnityOfWork
	{
		private const string ConnectionStringName = "EmployeeDataModelContainer";
		private readonly ObjectContext _context;

		private SqlRepository<Employee> _employees;
		private SqlRepository<TimeCard> _timeCards;

		public SqlUnityOfWork()
		{
			var connectionsString = ConfigurationManager.ConnectionStrings[ConnectionStringName]
				.ConnectionString;
			_context = new ObjectContext(connectionsString);
			_context.ContextOptions.LazyLoadingEnabled = true;
		}

		public IRepository<Employee> Employees => _employees ?? (_employees = new SqlRepository<Employee>(_context));

		public IRepository<TimeCard> TimeCards => _timeCards ?? (_timeCards = new SqlRepository<TimeCard>(_context));

		public void Commit()
		{
			_context.SaveChanges();
		}
	}
}