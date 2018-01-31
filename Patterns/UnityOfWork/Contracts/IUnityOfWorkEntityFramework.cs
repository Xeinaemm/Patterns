using System.Data.Entity.Core.Objects;
using Patterns.UnityOfWork.Entities;

namespace Patterns.UnityOfWork.Contracts
{
	public interface IUnityOfWorkEntityFramework
	{
		IObjectSet<Employee> Employees { get; }
		IObjectSet<TimeCard> TimeCards { get; }
		void Commit();
	}
}