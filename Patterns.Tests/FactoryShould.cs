using Patterns.Factory.Contracts;
using Patterns.Factory.Implementation;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class FactoryShould
	{
		[Theory]
		[AutoMoqData]
		public void BeAssignableFromIAutoFactoryForMiniCooper(MiniCooperFactory sut)
		{
			Assert.IsAssignableFrom<IAutoFactory>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void CreateMiniCooperSportCar(MiniCooperFactory sut)
		{
			var auto = sut.CreateSportCar();

			var actual = Assert.IsAssignableFrom<IAutomobile>(auto);

			const string expected = "Mini Cooper S";

			Assert.Equal(expected, actual.TurnOn());
		}

		[Theory]
		[AutoMoqData]
		public void CreateMiniCooperLuxuryCar(MiniCooperFactory sut)
		{
			var auto = sut.CreateLuxuryCar();

			var actual = Assert.IsAssignableFrom<IAutomobile>(auto);

			const string expected = "Mini Cooper with leather upholstery";

			Assert.Equal(expected, actual.TurnOn());
		}

		[Theory]
		[AutoMoqData]
		public void CreateMiniCooperEconomyCar(MiniCooperFactory sut)
		{
			var auto = sut.CreateEconomyCar();

			var actual = Assert.IsAssignableFrom<IAutomobile>(auto);

			const string expected = "Mini Cooper";

			Assert.Equal(expected, actual.TurnOn());
		}

		[Theory]
		[AutoMoqData]
		public void CreateBMWEconomyCar(BMWFactory sut)
		{
			var auto = sut.CreateEconomyCar();

			var actual = Assert.IsAssignableFrom<IAutomobile>(auto);

			const string expected = "BMW 328i";

			Assert.Equal(expected, actual.TurnOn());
		}

		[Theory]
		[AutoMoqData]
		public void CreateBMWLuxuryCar(BMWFactory sut)
		{
			var auto = sut.CreateLuxuryCar();

			var actual = Assert.IsAssignableFrom<IAutomobile>(auto);

			const string expected = "BMW 740i";

			Assert.Equal(expected, actual.TurnOn());
		}

		[Theory]
		[AutoMoqData]
		public void CreateBMWSportCar(BMWFactory sut)
		{
			var auto = sut.CreateSportCar();

			var actual = Assert.IsAssignableFrom<IAutomobile>(auto);

			const string expected = "BMW M3";

			Assert.Equal(expected, actual.TurnOn());
		}
	}
}