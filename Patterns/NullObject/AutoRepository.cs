namespace Patterns.NullObject
{
	public class AutoRepository
	{
		public static AutomobileBase Find(string carName)
		{
			if (carName.Contains("mini"))
				return new MiniCooper();
			return AutomobileBase.NULL;
		}
	}
}