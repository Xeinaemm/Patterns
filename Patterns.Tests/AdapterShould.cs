using AutoFixture.Xunit2;
using Moq;
using Patterns.Adapter;
using Patterns.Adapter.Contract;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class AdapterShould
	{
		[Theory]
		[AutoMoqData]
		public void ReturnValidNumberOfItems([Frozen] Mock<IClient> mock, AdapterValidator sut)
		{
			mock.Setup(x => x.GetNumberOfItems())
				.Returns(5);

			Assert.Equal(5, sut.Count);
		}
	}
}