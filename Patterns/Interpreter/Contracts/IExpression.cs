using Patterns.Interpreter.Models;

namespace Patterns.Interpreter.Contracts
{
	public interface IExpression
	{
		void Interpret(Context context);
	}
}