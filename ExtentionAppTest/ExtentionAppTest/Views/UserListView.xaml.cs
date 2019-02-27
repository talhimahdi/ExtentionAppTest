using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExtentionAppTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserListView : ContentPage
	{
		public UserListView ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new LoginView());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var x = await Application.Current.MainPage.DisplayActionSheet("Title", "Cancel", "Destruction");

        }

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            var x = await Application.Current.MainPage.DisplayActionSheet("Title", "Swipped", "OK");
        }
    }
}