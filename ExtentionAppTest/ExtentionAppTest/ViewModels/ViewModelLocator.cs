
using Xamarin.Forms;
using ExtentionAppTest.Services;
using ExtentionAppTest.IServices;
using ExtentionAppTest.IViewModels;
using Xamarin.Forms.Popups;
using Xamarin.Forms.Navigation;

namespace ExtentionAppTest.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            DependencyService.Register<IUserListVM, UserListVM>();
            DependencyService.Register<IUserDetailsVM, UserDetailsVM>();
            DependencyService.Register<ILoginVM, LoginVM>();


            DependencyService.Register<IUserServices, UserServices>();
            /*DependencyService.Register<IPopupsService, PopupsService>();
            DependencyService.Register<INavigationService, NavigationService>();*/
        }


        public IUserListVM UserList => DependencyService.Get<IUserListVM>();
        public IUserDetailsVM UserDetails => DependencyService.Get<IUserDetailsVM>();
        public ILoginVM Login => DependencyService.Get<ILoginVM>();
    }
}
