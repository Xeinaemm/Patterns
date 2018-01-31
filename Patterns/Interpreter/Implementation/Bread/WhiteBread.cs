using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation.Bread
{
	public class WhiteBread : IBread
	{
		public void Interpret(Context context)
		{
			context.Output += " White-IBread ";
		}
	}
}