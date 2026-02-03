namespace M009;

[QueryProperty(nameof(Zahl), "Zahl")]
public partial class Page2 : ContentPage
{
	private int zahl;

	/// <summary>
	/// Das Property zum Empfangen von Daten MUSS sein Set-only Property sein
	/// </summary>
	public int Zahl { set => zahl = value; }

	public Page2()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}
}