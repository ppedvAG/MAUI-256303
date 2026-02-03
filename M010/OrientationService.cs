namespace M010;

/// <summary>
/// Hier wird eine partielle Klasse definiert
/// Innerhalb der Platforms Ordner (Android, Windows) müssen die gleichen partiellen Klassen generiert werden
/// Beim Compilevorgang, werden diese partiellen Klassen je nach Plattform zusammengebaut
/// WICHTIG: Wenn hier eine Fehlermeldung auftritt, ist vermutlich in einem Platform Ordner noch keine Implementierung vorhanden (OSX, iOS)
/// WICHTIG: Alle partiellen Klassen müssen den gleichen Namespace haben
/// </summary>
public partial class OrientationService
{
	public partial Orientation GetOrientation();
}

public enum Orientation
{
	Portrait, Landscape, Unknown
}