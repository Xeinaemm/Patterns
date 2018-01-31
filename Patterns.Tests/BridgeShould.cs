using Patterns.Bridge.Formatters;
using Patterns.Bridge.Implementation;
using Xunit;

namespace Patterns.Tests
{
	public class BridgeShould
	{
		[Fact]
		public void ReturnBackwardsFormattedString()
		{
			var sut = new Book(new BackwardsFormatter())
			{
				Author = "Author",
				Text = "Text",
				Title = "Title"
			};

			var format = sut.Print();
			Assert.Equal("Title: eltiT Author: rohtuA Text: txeT", format);
		}

		[Fact]
		public void ReturnDefultFormattedString()
		{
			var sut = new Book(new StandardFormatter())
			{
				Author = "Author",
				Text = "Text",
				Title = "Title"
			};

			var format = sut.Print();
			Assert.Equal("Title: Title Author: Author Text: Text", format);
		}
	}
}