namespace M008;

class ColorsExtension : IMarkupExtension
{
	public object ProvideValue(IServiceProvider serviceProvider)
	{
		return typeof(Colors).GetFields().Select(e => new NamedColor() { Name = e.Name, Color = (Color) e.GetValue(null) }).ToList();
	}
}

public class NamedColor
{
	public string Name { get; set; }

	public Color Color { get; set; }
}