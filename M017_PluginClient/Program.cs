using M017_PluginBase;
using System.Reflection;

namespace M017_PluginClient;

internal class Program
{
	static void Main(string[] args)
	{
		string pfad = @"C:\Users\lk3\source\repos\MAUI_2026_02_02\M017_PluginCalculator\bin\Debug\net9.0\M017_PluginCalculator.dll";

		IPlugin calc = LoadPlugin(pfad);

		Console.WriteLine($"Name: {calc.Name}");
		Console.WriteLine($"Beschreibung: {calc.Description}");
		Console.WriteLine($"Autor: {calc.Author}");
		Console.WriteLine($"Version: {calc.Version}");

		MethodInfo[] array = calc.GetType()
			.GetMethods()
			.Where(e => e.GetCustomAttribute<ReflectionVisible>() != null)
			.ToArray();

		for (int i = 0; i < array.Length; i++)
		{
			MethodInfo mi = array[i];
			Console.WriteLine($"{i}: {mi.Name}");
		}
		Console.WriteLine("Gib eine Zahl ein: ");
		Console.ReadLine();
	}

	public static IPlugin LoadPlugin(string pfad)
	{
		Assembly a = Assembly.LoadFrom(pfad);

		Type foundPluginType = a.GetTypes().First(e => e.GetInterface(nameof(IPlugin)) != null);

		return (IPlugin) Activator.CreateInstance(foundPluginType);
	}
}
