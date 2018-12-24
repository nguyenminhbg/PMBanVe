using System;
using PMBanVe.ViewModels;
using PMBanVe.ViewModels.Home;
using PMBanVe.ViewModels.Login;
using PMBanVe.Views;
using PMBanVe.Views.Home;
using PMBanVe.Views.Login;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PMBanVe
{
    public partial class App
    {
        public App()
        {
           
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            // NavigationService.NavigateAsync("Navigation/LoginPage");
            MainPage = new NavigationPage(new LoginPage());
            ((NavigationPage)MainPage).BarBackgroundColor = Color.FromRgb(241, 90, 37);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<PMHomePage, PMHomePageViewModel>();
        }
    }
}
