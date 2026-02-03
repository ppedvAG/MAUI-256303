using System.Reflection;

namespace M009;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		//Navigation.PushAsync(new MainPage(), true);

		NavigationHelper.NavigateToView(nameof(MainPage));

		///////////////////////////////////////////////////////////////////

		//Daten per Navigation weitergeben
		int x = 3824;
		Shell.Current.GoToAsync($"//Page2?Zahl={x}");
	}
}

public static class NavigationHelper
{
	public static void NavigateToView(string name)
	{
		Type t = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

		Page p = Activator.CreateInstance(t) as Page;

		App.Current.MainPage.Navigation.PushAsync(p);
	}

	/// <summary>
	/// Navigation ohne Shell, mit Daten
	/// </summary>
	public static void NavigateToView(string name, object data)
	{
		Type t = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

		Page p = Activator.CreateInstance(t, data) as Page;

		App.Current.MainPage.Navigation.PushAsync(p);
	}
}