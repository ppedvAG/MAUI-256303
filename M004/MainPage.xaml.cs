namespace M004;

public partial class MainPage : ContentPage
{
	private int count;

	private double value;

	public MainPage()
	{
		InitializeComponent();

		Zahlen.ItemsSource = Enumerable.Range(0, 10).ToList();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
	}

	private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
	{

    }

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		value = e.NewValue;
		Output.Text = value.ToString();
	}
}
