using ExtentionAppTest.IViewModels;
using ExtentionAppTest.Models;

namespace ExtentionAppTest.ViewModels
{
    class UserDetailsVM : BaseViewModel, IUserDetailsVM
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }


    }
}
