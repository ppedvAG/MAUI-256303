using System.Globalization;

namespace M008;

class NamedColorToColorConverter : IValueConverter
{
	public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
	{
		if (value == null)
			return Color.FromArgb("#00000000");

		NamedColor nc = (NamedColor) value;
		return nc.Color;
	}
}
