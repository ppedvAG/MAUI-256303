namespace M010;

public partial class MainPage : ContentPage
{
	int count = 0;

	private OrientationService service = new();

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (service.GetOrientation() == Orientation.Landscape)
			Output.Text = "Landscape";
		else
			Output.Text = "Portrait";

		//if (DeviceInfo.Platform == DevicePlatform.WinUI)
		//	CounterBtn.Text = $"Clicked {count} time (Windows)";

		//if (DeviceInfo.Platform == DevicePlatform.Android)
		//	CounterBtn.Text = $"Clicked {count} times (Android)";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
