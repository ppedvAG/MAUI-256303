using System.Globalization;

namespace M011;

internal class LocalizedStringExtension : IMarkupExtension
{
	public string Key { get; set; }

	public Dictionary<string, string> Keys_de_DE;

	public Dictionary<string, string> Keys_en_US;

	public object ProvideValue(IServiceProvider serviceProvider)
	{
		CultureInfo current = CultureInfo.CurrentCulture;
		switch (current.Name)
		{
			case "de_DE":
				if (Keys_de_DE == null)
				{
					string file = File.ReadAllText("Strings.de_DE.txt");
					Keys_de_DE = file.Split("\n").ToDictionary(e => e.Split("=")[0], e => e.Split("=")[1]);
				}

				if (!Keys_de_DE.ContainsKey(Key))
					return "ERROR";

				return Keys_de_DE[Key];
		}
		return null;
	}
}
