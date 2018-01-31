using System;

namespace Patterns.Prototype
{
	public class Util
	{
		public void JustUtil()
		{
			var webPage = new WebPageScraper("http://google.com");
			webPage.PrintPageData();

			var secondWebPage = webPage.Clone() as WebPageScraper;
			secondWebPage?.PrintPageData();

			var logicPuzzle = new LogicPuzzle();
			logicPuzzle.SwitchBlueSwitch();
			logicPuzzle.SwitchRedSwitch();
			logicPuzzle.ToggleBigToggle();
			logicPuzzle.ToggleSmallToggle();
			logicPuzzle.PrintState();

			var secondLogicPuzzle = logicPuzzle.Clone() as LogicPuzzle;
			secondLogicPuzzle?.PrintState();

			Console.ReadKey();
		}
	}
}