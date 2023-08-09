using Navigations.MVVM.ViewModels;
using Navigations.Utilities;

namespace Navigations.MVVM;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();

		BindingContext = new StartPageViewModel();
	}

    /* Override the method that's called when the app UI opens to add the Examine method to it.. so we can visualise it from this page */

    protected override void OnAppearing()
	{
		base.OnAppearing();

		NavigationUtilities.Examine(Navigation);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		/* move to page 2 */

		Navigation.PushAsync(new Page2());
    }


	 /* Refer to Navigation/Utilities/NavigationUtilities.RemovePage() */
	private void Button_Clicked_1(object sender, EventArgs e)
	{
		/* move to page 2 and remove the StartPage */
        Navigation.PushAsync(new Page2());

        NavigationUtilities.RemovePage(Navigation, "StartPage");
	}

	/* This button takes us to a modal page. A modal page is a page that the user cannot excape from, except through any means the dev has provided 
	 for instance, only after completing the form in the page that this button leads to will they be able to move on (No back button)*/
	private void Button_Clicked_2(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new AddedPage(profileName.Text));
	}


	/* This method is used to practice passing data from one page to another, as above, but using the ViewModel *
	 * 
	private void Button_Clicked_2b(object sender, EventArgs e)
	{
		/* get the current BindingContext (as the corresponding ViewModel) */
	/*
		var currentViewModel = ((StartPageViewModel)BindingContext).Name;

		Navigation.PushModalAsync(new AddedPage
		{
			BindingContext = new AddedPageViewModel
			{
				Name = currentViewModel
			}
		});
	}

	*/
}