using System.Windows.Input;

namespace M013;

internal class CustomCommand : ICommand
{
	private Action<object> _execute;

	private Func<object, bool> _canExecute;

	public CustomCommand(Action<object> exe, Func<object, bool> canExe = null)
	{
		_execute = exe;
		_canExecute = canExe;
	}

	/////////////////////////////////////////////////////////////////////

	public event EventHandler? CanExecuteChanged;

	public void Execute(object? parameter)
	{
		_execute?.Invoke(parameter);
	}

	public bool CanExecute(object? parameter)
	{
		if (_canExecute == null)
			return true;
		return _canExecute.Invoke(parameter);
	}
}
