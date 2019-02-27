using ExtentionAppTest.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ExtentionAppTest.Views.Behaviors
{
    class ListViewBehavior : Behavior<ListView>
    {
        ListView listView;

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);

            listView = bindable;
            listView.ItemSelected += OnListViewItemSelected;
            listView.SeparatorColor = Color.Black;
        }



        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                Vibration.Vibrate(TimeSpan.FromSeconds(1));
                User si = listView.SelectedItem as User;
                Application.Current.MainPage.Navigation.PushAsync(new UserDetailsView(si));
                listView.SelectedItem = null;
            }
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            listView.ItemSelected -= OnListViewItemSelected;
        }
 
    }
}
