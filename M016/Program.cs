using System.Reflection;

namespace M016;

internal class Program
{
	public string Name { get; set; }

	private int count;

	static void Main(string[] args)
	{
		Type t = typeof(Program);

		Program obj = new Program();
		Type p = obj.GetType();

		//Objekt verwenden, ohne es direkt anzusprechen
		p.GetProperty("Name").SetValue(obj, "Hallo Welt");
		Console.WriteLine(p.GetProperty("Name").GetValue(obj));

		p.GetMethod("Hallo").Invoke(obj, null);

		//Private Felder beschreiben
		p.GetField("count", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(obj, 123);

		//////////////////////////////////////////////////////////////////

		//Activator
		//Objekte erstellen über einen Typen
		object o = Activator.CreateInstance(t);

		t.GetProperty("Name").SetValue(o, "Max Mustermann");

		//Assembly
		//Grob gesagt eine DLL
		//Fein gesagt eine Sammlung von Codestücken, die zu einer DLL zusammengefasst werden
		Assembly a = Assembly.GetExecutingAssembly(); //Das jetztige Projekt

		//Kann auch externe DLLs laden
		Assembly loaded = Assembly.LoadFrom(@"C:\Users\lk3\source\repos\MAUI_2026_02_02\M014\bin\Debug\net9.0\M014.dll");

		//////////////////////////////////////////////////////////////////

		//Aufgabe: Komponente dynamisch laden
		Assembly componentAssembly = loaded;

		Type compType = componentAssembly.GetType("M014.Component");
		object comp = Activator.CreateInstance(compType);
		compType.GetEvent("Start").AddEventHandler(comp, () => Console.WriteLine("Reflection Component Start"));
		compType.GetEvent("End").AddEventHandler(comp, () => Console.WriteLine("Reflection Component End"));
		compType.GetEvent("Progress").AddEventHandler(comp, (int x) => Console.WriteLine($"Reflection Fortschritt: {x}"));
		compType.GetMethod("Run").Invoke(comp, null);
	}

	public void Hallo()
	{
		Console.WriteLine("Hallo Welt!");
	}
}
