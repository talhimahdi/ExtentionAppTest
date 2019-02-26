using ExtentionAppTest.Models;
using System;
using System.Collections.Generic;
using ExtentionAppTest.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExtentionAppTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserDetailsView : ContentPage
	{
        private UserDetailsVM VM;
		public UserDetailsView ()
		{
			InitializeComponent ();
		}
        public UserDetailsView(User user)
        {
            InitializeComponent();
            //VM = new ViewModelLocator().UserDetails as UserDetailsVM;
            VM = Resources["vm"] as UserDetailsVM;
            VM.User = user;
            
        }
    }
}