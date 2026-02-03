namespace M012;

internal class ActionFunc
{
	static void Main(string[] args)
	{
		//Action und Func
		//Vorgegebene Delegates, die an vielen Stellen verwendet werden
		//Essentiell für die Fortgeschrittene Programmierung
		//z.B.: Tasks, Linq, Reflection, ...

		//Action
		//Methodenzeiger mit void und bis zu 16 Parameter
		Action<int, int> add = new Action<int, int>(Addieren); //Über die Generics werden die Parametertypen vorgegeben
		add?.Invoke(3, 4);

		//Beispiel für Action
		List<int> zahlen = [1, 2, 3, 4, 5];
		zahlen.ForEach(Hoch2);

		//Func
		//Methodenzeiger mit einem beliebigen Rückgabewert und bis zu 16 Parameter
		Func<int, int, double> div = Dividiere;
		double? d = div?.Invoke(3, 4);

		double d2;
		if (div == null)
			d2 = double.NaN;
		else
			d2 = div.Invoke(3, 4);

		double d3 = div == null ? double.NaN : div.Invoke(3, 4);

		double d4 = div?.Invoke(3, 4) ?? double.NaN;

		//Beispiel für Func
		zahlen.Where(Dividiere);

		//Anonyme Funktionen
		//Delegates, die keine dedizierten Parameter haben
		div = delegate (int x, int y)
		{
			return (double) x / y;
		};

		div += (int x, int y) =>
		{
			return (double) x / y;
		};

		div += (int x, int y) => (double) x / y;

		div += (x, y) => (double) x / y;

		//anonyme Funktionen als Parameter
		zahlen.ForEach(e => Console.WriteLine(e));
		zahlen.ForEach(Console.WriteLine);

		string text = "Hallo Welt";
		text.All(char.IsLetter);
	}

	public static void Addieren(int x, int y)
	{
		Console.WriteLine($"{x} + {y} = {x + y}");
	}

	public static void Hoch2(int x)
	{
		Console.WriteLine($"{x}^2={x * x}");
	}

	public static double Dividiere(int x, int y)
	{
		return (double) x / y;
	}

	public static bool Dividiere(int x)
	{
		return x % 2 == 0;
	}
}
