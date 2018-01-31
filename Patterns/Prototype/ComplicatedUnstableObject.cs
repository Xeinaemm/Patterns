using System;

// ReSharper disable UnusedParameter.Local

namespace Patterns.Prototype
{
	public class ComplicatedUnstableObject : ICloneable
	{
		public ComplicatedUnstableObject(string a, int b, int c, char d, string e)
		{
		}

		public ComplicatedUnstableObject(int ba, int c, char d, string e)
		{
		}

		public ComplicatedUnstableObject(string a, char da, string e)
		{
		}

		public ComplicatedUnstableObject(string a, int c, char d, string e, string f)
		{
		}

		public object Clone() => MemberwiseClone();
	}
}