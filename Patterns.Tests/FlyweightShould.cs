using AutoFixture.Xunit2;
using Moq;
using Patterns.Flyweight.Contracts;
using Patterns.Flyweight.Implementation;
using Patterns.Flyweight.Implementation.Tiles;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class FlyweightShould
	{
		[Theory]
		[InlineAutoMoqData("Ceramic")]
		[InlineAutoMoqData("Stone")]
		public void CreateCorrectTile(string expected, TileFactory sut)
		{
			var tile = sut.GetTile(expected);
			var t = Assert.IsAssignableFrom<ITile>(tile);

			Assert.Equal(expected, t.Print());
		}

		[Theory]
		[InlineAutoMoqData("Ceramic")]
		[InlineAutoMoqData("Stone")]
		public void BeInvokedOnlyOnce(string tileName, [Frozen] Mock<TileFactory> tileFactoryMock)
		{
			tileFactoryMock.Object.GetTile(tileName);
			tileFactoryMock.Verify(x => x.GetTile(tileName), Times.Once);
		}

		[Theory]
		[AutoData]
		public void CreateNullTileIfNameDontMatch([Frozen] Mock<TileFactory> tileFactoryMock)
		{
			var tile = tileFactoryMock.Object.GetTile(It.IsAny<string>());
			Assert.True(tile is NullTile);
		}
	}
}