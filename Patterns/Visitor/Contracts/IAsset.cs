namespace Patterns.Visitor.Contracts
{
	public interface IAsset
	{
		void Accept(IVisitor visitor);
	}
}