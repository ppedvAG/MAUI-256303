namespace M012;

/// <summary>
/// Delegates
/// 
/// Behälter für Methodenzeiger
/// </summary>
internal class Delegates
{
	/// <summary>
	/// Ein Delegate gibt einen Methodenaufbau vor (Rückgabewert, Parameter)
	/// Es kann erzeugt werden, und es können Methoden angehängt werden
	/// Es kann im Anschluss auch ausgeführt werden
	/// </summary>
	public delegate void Vorstellung(string name);

	static void Main(string[] args)
	{
		Vorstellung v = new Vorstellung(VorstellungDE); //Erstellung eines Delegates mit einer Initialmethode
		v("Max"); //Delegate ausführen

		v += VorstellungEN; //Weitere Methode anhängen
		v("Tim");

		v += VorstellungEN;
		v += VorstellungEN;
		v += VorstellungEN;
		v += VorstellungEN;
		v += VorstellungEN; //Gleiches Delegate mehrmals angehängt
		v("Udo");

		for (int i = 0; i < 100; i++)
			v -= VorstellungEN;  //Delegate abnehmen

		v("Max"); //Keine Fehler bei Abnahme, wenn das Delegate nicht angehängt ist

		v -= VorstellungDE;
		//v("Tim"); //Wenn die letzte Methode abgenommen wird, ist das Delegate null
		if (v != null)
			v("Tim");
		v?.Invoke("Tim"); //Null propagation

		foreach (Delegate dg in v.GetInvocationList())
		{
			Console.WriteLine(dg.Method.Name);
		}
	}

	public static void VorstellungDE(string name)
	{
		Console.WriteLine($"Hallo mein Name ist {name}");
	}

	public static void VorstellungEN(string name)
	{
		Console.WriteLine($"Hello my name is {name}");
	}
}
