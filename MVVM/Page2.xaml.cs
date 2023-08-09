using Navigations.MVVM.ViewModels;
using Navigations.Utilities;

namespace Navigations.MVVM;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	public object NavifationUtilities { get; private set; }

    /* Override the method that's called when the app UI opens to add the Examine method to it.. so we can visualise it from this page */

    protected override void OnAppearing()
	{
		base.OnAppearing();

		NavigationUtilities.Examine(Navigation);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		/* move to the next page (page 3) */

		Navigation.PushAsync(new Page3());
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		/* since we are in the next page, instead of creating a new instance of startPage, we just pop from the stack */

		Navigation.PopAsync();
	}
}