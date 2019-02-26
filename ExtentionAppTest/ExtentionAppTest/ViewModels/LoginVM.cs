using ExtentionAppTest.Utils;
using ExtentionAppTest.IViewModels;
using Xamarin.Forms;
using System;

namespace ExtentionAppTest.ViewModels
{
    class LoginVM : BaseViewModel, ILoginVM 
    {
        public Command SwipeCommand { get; set; }
        private bool Swipped { get; set; }
        private string _userName { get; set; }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));

                Settings.UserName = value;
            }
        }

        public LoginVM()
        {
            _userName = Settings.UserName;
            Swipped = true;
            SwipeCommand = new Command(OnSwipe);
        }

        private void OnSwipe( object obj)
        {
            Swipped = false;
            Application.Current.MainPage.DisplayAlert("Test", "Swipe Test!", "OK");
        }
    }
}
