using System.Linq;
using Patterns.Bridge.Contract;

namespace Patterns.Bridge.Formatters
{
	public class BackwardsFormatter : IFormatter
	{
		public string Format(string key, string value) =>
			$"{key}: {new string(value.Reverse() .ToArray())}";
	}
}