using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ExtentionAppTest.IServices;
using ExtentionAppTest.IViewModels;
using ExtentionAppTest.Models;
using ExtentionAppTest.Services;


namespace ExtentionAppTest.ViewModels
{
    class UserListVM : BaseViewModel, IUserListVM
    {
        private readonly IUserServices _userServices;
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
            Users = new ObservableCollection<User>();
            
            GetUsers();

        }

        private async void GetUsers()
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


    }
}
