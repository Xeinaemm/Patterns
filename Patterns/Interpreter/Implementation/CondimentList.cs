using System.Collections.Generic;
using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation
{
	public class CondimentList : IExpression
	{
		private readonly IList<ICondiment> _condiments;

		public CondimentList(IList<ICondiment> condiments) => _condiments = condiments;

		public void Interpret(Context context)
		{
			foreach (var condiment in _condiments)
				condiment.Interpret(context);
		}
	}
}