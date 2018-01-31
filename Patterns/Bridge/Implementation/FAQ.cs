using Patterns.Bridge.Contract;

namespace Patterns.Bridge.Implementation
{
	public class FAQ : IManuscript
	{
		private readonly IFormatter _formatter;

		public FAQ(IFormatter formatter) => _formatter = formatter;

		public string Print() =>
			$"{_formatter.Format("Empty", "Empty")}";
	}
}