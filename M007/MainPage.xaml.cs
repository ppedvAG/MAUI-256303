using System.Collections.ObjectModel;

namespace M007
{
	public partial class MainPage : ContentPage
	{
		public ObservableCollection<int> Zahlen { get; set; } = new ObservableCollection<int>(Enumerable.Range(20, 50));

		public MainPage()
		{
			InitializeComponent();
		}
	}
}
