using Navigations.MVVM;

namespace Navigations;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartPage());
	}
}
