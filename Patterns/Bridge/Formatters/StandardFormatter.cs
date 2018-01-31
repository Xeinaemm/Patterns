using Patterns.Bridge.Contract;

namespace Patterns.Bridge.Formatters
{
	public class StandardFormatter : IFormatter
	{
		public string Format(string key, string value) =>
			$"{key}: {value}";
	}
}