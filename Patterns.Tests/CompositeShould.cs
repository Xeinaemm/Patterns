using Patterns.Composite.Contracts;
using Patterns.Composite.Implementation;
using Patterns.Tests.Helpers;
using Xunit;

namespace Patterns.Tests
{
	public class CompositeShould
	{
		[Theory]
		[AutoMoqData]
		public void BeAssignableFromIPartyForGroup(Group sut)
		{
			Assert.IsAssignableFrom<IParty>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void BeAssignableFromIPartyForPerson(Person sut)
		{
			Assert.IsAssignableFrom<IParty>(sut);
		}

		[Theory]
		[AutoMoqData]
		public void ReturnZeroWhenCollectionOfMembersAreEmpty(Group sut)
		{
			Assert.Equal(0, sut.Gold);
		}

		[Fact]
		public void SplitCorrectSplitGold()
		{
			var goldForKill = 1026;

			var joe = new Person {Name = "Joe"};
			var jake = new Person {Name = "Jake"};
			var emily = new Person {Name = "Emily"};
			var sophia = new Person {Name = "Sophia"};
			var brian = new Person {Name = "Brian"};

			var developers = new Group {Name = "Developers", Members = {joe, jake, emily}};
			var parties = new Group {Members = {developers, sophia, brian}};

			parties.Gold += goldForKill;

			Assert.All(developers.Members, party => Assert.Equal(114, party.Gold));
		}
	}
}