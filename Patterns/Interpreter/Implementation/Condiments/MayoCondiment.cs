using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation.Condiments
{
	public class MayoCondiment : ICondiment
	{
		public void Interpret(Context context)
		{
			context.Output += " Mayo ";
		}
	}
}