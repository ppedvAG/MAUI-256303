using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace M013;

internal partial class MainPageViewModel : ObservableObject
{
	//private int count;

	//public int Count
	//{
	//	get => count;
	//	set
	//	{
	//		count = value;
	//		Notify();
	//	}
	//}

	//private string counterBtnText = "Click me";

	//public string CounterBtnText
	//{
	//	get => counterBtnText;
	//	set
	//	{
	//		counterBtnText = value;
	//		Notify();
	//	}
	//}

	//public CustomCommand CounterCommand { get; set; }

	//public MainPageViewModel()
	//{
	//	CounterCommand = new CustomCommand(OnCounterClicked);
	//}

	//private void OnCounterClicked(object o)
	//{
	//	Count++;

	//	if (count == 1)
	//		CounterBtnText = $"Clicked {count} time";
	//	else
	//		CounterBtnText = $"Clicked {count} times";
	//}

	////////////////////////////////////////////////////////////////////////////////

	[ObservableProperty]
	private int count;

	[ObservableProperty]
	private string counterBtnText = "Click me";

	public MainPageViewModel()
	{
		
	}

	[RelayCommand]
	private void OnCounterClicked(object o)
	{
		Count++;

		if (count == 1)
			CounterBtnText = $"Clicked {count} time";
		else
			CounterBtnText = $"Clicked {count} times";
	}
}
