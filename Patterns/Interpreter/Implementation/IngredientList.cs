using System.Collections.Generic;
using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation
{
	public class IngredientList : IExpression
	{
		private readonly IList<IIngredient> _ingredients;

		public IngredientList(IList<IIngredient> ingredients) => _ingredients = ingredients;

		public void Interpret(Context context)
		{
			foreach (var ingredient in _ingredients)
				ingredient.Interpret(context);
		}
	}
}