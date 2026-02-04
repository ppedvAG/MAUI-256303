using System.ServiceModel;

namespace M014;

internal class Program
{
	static void Main(string[] args)
	{
		//class und struct

		//class
		//Referenztyp
		//Wenn eine Klasse auf eine Variable zugewiesen wird, wird eine Referenz erzeugt
		//Wenn zwei Variablen von Klassen verglichen werden, werden die Speicheradressen verglichen
		Test t1 = new Test(); //Zeiger auf Objekt
		Test t2 = t1; //Zeiger auf das gleiche Objekt
		t1.Zahl = 10;

		Console.WriteLine(t1 == t2);
		Console.WriteLine(t1.GetHashCode() == t2.GetHashCode());

		//struct
		//Wertetyp
		//Wenn ein Struct auf eine Variable zugewiesen wird, wird eine Kopie erzeugt
		//Wenn zwei Variablen von Structs verglichen werden, werden die Inhalte verglichen
		int z1 = 10;
		int z2 = z1;
		z1 = 5;

		//structs referenzierbar machen
		//ref-Keyword
		int zahl1 = 5;
		ref int zahl2 = ref zahl1;
		zahl2 = 10;

		////////////////////////////////////////////////////////////////////////////

		Interlocked.Increment(ref zahl1);
	}
}

public class Test
{
	public int Zahl;
}
