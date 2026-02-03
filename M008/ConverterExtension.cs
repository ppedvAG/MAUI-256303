namespace M008;

class ConverterExtension : IMarkupExtension
{
	public Type ConverterType { get; set; }

	public object ProvideValue(IServiceProvider serviceProvider)
	{
		if (ConverterType.GetInterface(nameof(IValueConverter)) == null)
			throw new ArgumentException("ConverterType ist kein Converter");

		return Activator.CreateInstance(ConverterType);
	}
}
