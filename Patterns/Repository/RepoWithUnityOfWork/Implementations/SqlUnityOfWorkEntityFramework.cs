using System.Configuration;
using System.Data.Entity.Core.Objects;
using Patterns.Repository.RepoWithUnityOfWork.Contracts;
using Patterns.Repository.RepoWithUnityOfWork.Entities;

namespace Patterns.Repository.RepoWithUnityOfWork.Implementations
{
	public class SqlUnityOfWorkEntityFramework : IUnityOfWorkEntityFramework
	{
		private const string ConnectionStringName = "EmployeeDataModelContainer";

		private readonly ObjectContext _context;

		public SqlUnityOfWorkEntityFramework()
		{
			var connectionString =
				ConfigurationManager
					.ConnectionStrings[ConnectionStringName]
					.ConnectionString;

			_context = new ObjectContext(connectionString);
			_context.ContextOptions.LazyLoadingEnabled = true;
		}

		public IObjectSet<Employee> Employees => _context.CreateObjectSet<Employee>();

		public IObjectSet<TimeCard> TimeCards => _context.CreateObjectSet<TimeCard>();

		public void Commit()
		{
			_context.SaveChanges();
		}
	}
}