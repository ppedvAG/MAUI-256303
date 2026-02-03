using Android.Content;
using Android.Runtime;
using Android.Views;

namespace M010;

public partial class OrientationService
{
	public partial Orientation GetOrientation()
	{
		IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
		SurfaceOrientation orientation = windowManager.DefaultDisplay.Rotation;
		bool isLandscape = orientation == SurfaceOrientation.Rotation90 || orientation == SurfaceOrientation.Rotation270;
		return isLandscape ? Orientation.Landscape : Orientation.Portrait;
	}
}
