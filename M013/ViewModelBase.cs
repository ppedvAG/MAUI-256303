using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace M013;

internal class ViewModelBase : INotifyPropertyChanged
{

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
}
