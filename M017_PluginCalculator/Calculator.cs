using M017_PluginBase;

namespace M017_PluginCalculator;

public class Calculator : IPlugin
{
	public string Name => "Rechner";

	public string Description => "Ein simpler Rechner";

	public string Version => "1.0";

	public string Author => "Lukas";

	[ReflectionVisible]
	public int Addiere(int x, int y) => x + y;

	[ReflectionVisible]
	public int Subtrahiere(int x, int y) => x - y;
}
