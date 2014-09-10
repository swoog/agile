namespace Cellenza.Quizz
{
    using System.Windows.Input;

    using Xamarin.Forms;

    public class MainViewModel : BaseViewModel
    {
        public ICommand AboutCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetPage<AboutPage, AboutViewModel>());
                });
            }
        }
        public ICommand QuizzCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetPage<AboutPage, AboutViewModel>());
                });
            }
        }

        public ICommand ToolsCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Navigation.PushAsync(App.GetPage<AboutPage, AboutViewModel>());
                });
            }
        }
    }
}