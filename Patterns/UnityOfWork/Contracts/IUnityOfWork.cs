using Patterns.UnityOfWork.Entities;

namespace Patterns.UnityOfWork.Contracts
{
	public interface IUnityOfWork
	{
		IRepository<Employee> Employees { get; }
		IRepository<TimeCard> TimeCards { get; }
		void Commit();
	}
}