using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation.Bread
{
	public class WheatBread : IBread
	{
		public void Interpret(Context context)
		{
			context.Output += " Wheat-IBread ";
		}
	}
}