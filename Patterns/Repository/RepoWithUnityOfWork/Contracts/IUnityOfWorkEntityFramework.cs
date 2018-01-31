using System.Data.Entity.Core.Objects;
using Patterns.Repository.RepoWithUnityOfWork.Entities;

namespace Patterns.Repository.RepoWithUnityOfWork.Contracts
{
	public interface IUnityOfWorkEntityFramework
	{
		IObjectSet<Employee> Employees { get; }
		IObjectSet<TimeCard> TimeCards { get; }
		void Commit();
	}
}