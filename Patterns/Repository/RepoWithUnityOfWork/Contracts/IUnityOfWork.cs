using Patterns.Repository.RepoWithUnityOfWork.Entities;

namespace Patterns.Repository.RepoWithUnityOfWork.Contracts
{
	public interface IUnityOfWork
	{
		IRepository<Employee> Employees { get; }
		IRepository<TimeCard> TimeCards { get; }
		void Commit();
	}
}