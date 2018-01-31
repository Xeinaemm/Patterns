using AutoFixture.Xunit2;
using Moq;
using Patterns.Facade.Contracts;
using Patterns.Facade.Converters;
using Patterns.Facade.Implementation;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class FacadeShould
	{
		[Theory]
		[AutoMoqData]
		public void ReturnCorrectCity([Frozen] Mock<IGeoLookupService> mockGLS, TemperatureFacade sut)
		{
			mockGLS.Setup(x => x.GetCity())
				.Returns(It.IsAny<string>());

			Assert.Equal(It.IsAny<string>(), sut.GetTemperature()
				.City);
		}

		[Theory]
		[AutoMoqData]
		public void ReturnCorrectState([Frozen] Mock<IGeoLookupService> mockGLS, TemperatureFacade sut)
		{
			mockGLS.Setup(x => x.GetState())
				.Returns(It.IsAny<string>());

			Assert.Equal(It.IsAny<string>(), sut.GetTemperature()
				.State);
		}

		[Theory]
		[AutoMoqData]
		public void ReturnCorrectTemperatureInCelcius(EnglishMetricConverter sut)
		{
			Assert.Equal(37.778, sut.Convert(100.0), 3);
		}
	}
}