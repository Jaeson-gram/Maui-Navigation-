using Navigations.MVVM.ViewModels;
using Navigations.Utilities;

namespace Navigations.MVVM;

public partial class AddedPage : ContentPage
{
	public AddedPage()
	{
		InitializeComponent();

		BindingContext = new AddedPageViewModel();
	}

    /* To recieve information */
    public AddedPage(string Name)
    {
        InitializeComponent();

		ProfileName.Text = Name;
    }

    protected override void OnAppearing()
	{
		base.OnAppearing();

		NavigationUtilities.InsertPage(Navigation);
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        /* this method PushModalAsync() is used when you  want the modal page to be removed, on Completing a task. 
		 Refer to StartPage.xaml.cs.Button_Clicked_2 for more info on this type of page */

		/* the modal page is on a whole new stack, so there's not moving  back from here... Only the page added in this button will be opened */

        Navigation.PopModalAsync();
	}

	/*
	private void Button_Clicked_1(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page2());
	}
	*/


	/* disable the back button so the user can't go back with the button either */
	protected override bool OnBackButtonPressed()
	{
		//return base.OnBackButtonPressed();	

		return true;
	}
}