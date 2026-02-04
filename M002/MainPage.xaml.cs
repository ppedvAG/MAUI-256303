namespace M001;

public partial class MainPage : ContentPage
{
	public AsyncDataSource Source = new AsyncDataSource();

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object? sender, EventArgs e)
	{
		await foreach (int x in Source.Generiere())
		{
			CounterBtn.Text = $"Zahl: {x}";
		}
	}
}
