using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation.Ingredients
{
	public class LettuceIngredient : IIngredient
	{
		public void Interpret(Context context)
		{
			context.Output += " Lettuce ";
		}
	}
}