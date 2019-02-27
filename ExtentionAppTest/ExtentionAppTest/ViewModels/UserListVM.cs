using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ExtentionAppTest.IServices;
using ExtentionAppTest.IViewModels;
using ExtentionAppTest.Models;
using ExtentionAppTest.Services;
using Xamarin.Forms;

namespace ExtentionAppTest.ViewModels
{
    class UserListVM : BaseViewModel, IUserListVM
    {
        private readonly IUserServices _userServices;
        private readonly IUtilsService _utilsServices;

        private bool _isRefreshing = false;
        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }
        public ObservableCollection<User> Users { get; set; }

        private int _itemsCount { get; set; }
        public int ItemsCount
        {
            get { return _itemsCount; } 
            set
            {
                _itemsCount = value;
                OnPropertyChanged(nameof(ItemsCount));
            }
        }

        public UserListVM() 
        {
            _userServices = new UserServices();
            _utilsServices = new UtilsService();

            Users = new ObservableCollection<User>();

            GetUsersAsync();

        }

        private async void GetUsersAsync()
        {
            await GetUsers();
        }

        public Command RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    IsRefreshing = true;

                    await GetUsers();

                    IsRefreshing = false;
                });
            }
        }

        private async Task GetUsers()
        {

            var checkInternet = await _utilsServices.CheckInternet();
            
            if (checkInternet)
            {
                List<User> list = await _userServices.GetUsers();
                Users.Clear();

                foreach (User user in list)
                {
                    if (user != null)
                        Users.Add(user);
                }
                ItemsCount = Users.Count;
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Internet Error", "Please check your internet connection", "OK");
            }
        }


    }
}
