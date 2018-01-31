namespace Patterns.State.Contracts
{
	public interface IUnityOfWork
	{
		IRepository<IEntity> Entities { get; }
		void Commit();
	}
}