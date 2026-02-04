using M018.Models;

namespace M018;

/// <summary>
/// Entity Framework
/// Stellt eine Relationale Datenbank in unserer Anwendung dar
/// Hierbei werden Klassen erzeugt, mit den Properties entsprechend der Spalten innerhalb der Tabelle
/// Wenn die Daten geladen werden, werden Objekte erzeugt für jeden Datensatz
/// </summary>
internal class Program
{
	static void Main(string[] args)
	{
		NorthwindContext db = new NorthwindContext();
		db.Customers.Where(e => e.Country == "UK");

		//db.Database.ExecuteSql("CREATE USER Name");
	}
}