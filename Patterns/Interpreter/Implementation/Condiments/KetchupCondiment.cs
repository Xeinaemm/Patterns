using Patterns.Interpreter.Contracts;
using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Implementation.Condiments
{
	public class KetchupCondiment : ICondiment
	{
		public void Interpret(Context context)
		{
			context.Output += " Ketchup ";
		}
	}
}