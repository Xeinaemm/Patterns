using Patterns.Bridge.Contract;

namespace Patterns.Bridge.Implementation
{
	public class Book : IManuscript
	{
		private readonly IFormatter _formatter;

		public Book(IFormatter formatter) => _formatter = formatter;

		public string Author { get; set; }

		public string Text { get; set; }

		public string Title { get; set; }

		public string Print() =>
			$"{_formatter.Format("Title", Title)} {_formatter.Format("Author", Author)} {_formatter.Format("Text", Text)}";
	}
}