using Patterns.Facade.Contracts;

namespace Patterns.Facade.Converters
{
	public class EnglishMetricConverter : IValueConverter<double>
	{
		public double Convert(object value) => ((double) value - 32) / 9.0 * 5.0;
	}
}