using Patterns.ServiceLocator.Contracts;

namespace Patterns.ServiceLocator
{
	public class Util
	{
		private readonly ILog log = Implementation.ServiceLocator.GetService<ILog>("logger");

		public void JustUtil()
		{
			log.Log("Test");
		}
	}
}