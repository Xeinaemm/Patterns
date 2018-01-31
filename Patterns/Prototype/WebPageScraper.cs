using System;
using System.Net;

// ReSharper disable UnusedParameter.Local

namespace Patterns.Prototype
{
	public class WebPageScraper : ICloneable
	{
		private string firstHeaderTagContents;
		private int headerTagCount;
		private string title;

		public WebPageScraper(string url)
		{
			var client = new WebClient();
			Scrape(client.DownloadString(url));
		}

		public object Clone() => MemberwiseClone();

		private void Scrape(string page)
		{
			title = "Fake title";
			headerTagCount = 3;
			firstHeaderTagContents = "Fake header text";
		}

		public void PrintPageData()
		{
			Console.WriteLine($"Title: {title}, Header Count: {headerTagCount}, First Header: {firstHeaderTagContents}");
		}
	}
}