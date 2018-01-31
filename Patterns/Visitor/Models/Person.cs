using System.Collections.Generic;
using Patterns.Visitor.Contracts;

namespace Patterns.Visitor.Models
{
	public class Person : IAsset
	{
		public readonly List<IAsset> Assets = new List<IAsset>();

		public void Accept(IVisitor visitor)
		{
			foreach (var asset in Assets)
				asset.Accept(visitor);
		}
	}
}