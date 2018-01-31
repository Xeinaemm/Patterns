using AutoFixture.Xunit2;
using Xunit;

namespace Patterns.Tests.Helpers
{
	public class InlineAutoMoqDataAttribute : CompositeDataAttribute
	{
		public InlineAutoMoqDataAttribute(params object[] values)
			: base(new InlineDataAttribute(values), new AutoMoqDataAttribute())
		{
		}
	}
}