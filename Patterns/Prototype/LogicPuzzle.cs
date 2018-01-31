using System;

namespace Patterns.Prototype
{
	public class LogicPuzzle : ICloneable
	{
		private bool bigToggle;
		private int blueSwitchCharge;
		private bool doorOpen;
		private int moveCount;
		private int redSwitchCharge;
		private bool slatLocked;
#pragma warning disable 649
		private bool smallToggle;
#pragma warning restore 649

		public object Clone() => MemberwiseClone();

		public void SwitchBlueSwitch()
		{
			if (smallToggle)
				blueSwitchCharge++;
			bigToggle = !bigToggle;
			moveCount++;
		}

		public void SwitchRedSwitch()
		{
			if (!smallToggle && blueSwitchCharge < 3)
			{
				doorOpen = true;
				blueSwitchCharge = 0;
			}
			else
			{
				redSwitchCharge++;
				slatLocked = true;
			}

			moveCount++;
		}

		public void ToggleBigToggle()
		{
			slatLocked = false;
			redSwitchCharge = 0;
			if (doorOpen)
				doorOpen = false;
			moveCount++;
		}

		public void ToggleSmallToggle()
		{
			if (blueSwitchCharge < 3 || redSwitchCharge > 5)
			{
				slatLocked = false;
				doorOpen = true;
			}

			moveCount++;
		}


		public void PrintState()
		{
			Console.WriteLine($"Blue switch charge: {blueSwitchCharge}");
			Console.WriteLine($"Red switch charge: {redSwitchCharge}");
			Console.WriteLine($"Small toggle: {smallToggle}");
			Console.WriteLine($"Big toggle: {bigToggle}");
			Console.WriteLine($"Door open: {doorOpen}");
			Console.WriteLine($"Slat locked: {slatLocked}");
			Console.WriteLine($"Move count: {moveCount}");
		}
	}
}