using Navigations.Utilities;

namespace Navigations.MVVM;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

	/* Override the method that's called when the app UI opens to add the Examine method to it.. so we can visualise it from this page */
	protected override void OnAppearing()
	{
		base.OnAppearing();

		NavigationUtilities.Examine(Navigation);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        /* since we are in the next page, instead of creating a new instance of the previous page, we just pop from the stack */

        Navigation.PopAsync();
	}

	private void Button_Clicked_1(object sender, EventArgs e)
	{
		/* this moves directly to the root page (and overrides the previous pages), instead of adding the root page to the stack */

		Navigation.PopToRootAsync();
	}

	private void Button_Clicked_2(object sender, EventArgs e)
	{
		/* add the specified page before the second page, when we click this button */

        NavigationUtilities.InsertPage(Navigation);
    }
}