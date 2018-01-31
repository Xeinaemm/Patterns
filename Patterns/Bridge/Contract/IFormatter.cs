namespace Patterns.Bridge.Contract
{
	public interface IFormatter
	{
		string Format(string key, string value);
	}
}