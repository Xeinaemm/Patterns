using Patterns.Decorator.Component;
using Patterns.Decorator.ConcreteComponents;
using Patterns.Decorator.ConcreteDecorators;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class DecoratorShould
	{
		[Theory]
		[AutoMoqData]
		public void BeAssignableFromIPizzaForCheese(Cheese sut)
		{
			Assert.IsAssignableFrom<IPizza>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void BeAssignableFromIPizzaForHam(Ham sut)
		{
			Assert.IsAssignableFrom<IPizza>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void BeAssignableFromIPizzaForPeppers(Peppers sut)
		{
			Assert.IsAssignableFrom<IPizza>(sut);
		}

		[Fact]
		public void CreateMediumPizzaWithCheeseHamPeppers()
		{
			IPizza sut = new MediumPizza();
			sut = new Cheese(sut);
			sut = new Ham(sut);
			sut = new Peppers(sut);

			var expected = new MediumPizza
			{
				Description = "Medium Pizza, Cheese, Ham, Peppers"
			};

			Assert.Equal(expected.Description, sut.GetDescription());
		}

		[Fact]
		public void CreateMediumPizzaWithCheeseHamPeppersAndCorrectPrice()
		{
			IPizza sut = new MediumPizza();
			sut = new Cheese(sut);
			sut = new Ham(sut);
			sut = new Peppers(sut);

			Assert.Equal(10.25, sut.CalculateCost());
		}
	}
}