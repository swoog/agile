using Cellenza.Quizz.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Cellenza.Quizz
{
    public class App
    {
        public static Page GetPage<TPage, TViewModel>()
            where TPage : Page, new()
            where TViewModel : BaseViewModel, new()
        {
            var view = new TPage();
            var vm = new TViewModel();
            view.BindingContext = vm;
            vm.Navigation = view.Navigation;

            return view;
        }

        public static Page GetStartPage()
        {
            return GetPage<MainPage, MainViewModel>();
        }

        public static int QuizzPoints { get; set; }

        public static int QuestionAnswered { get; set; }

        public static IMeuhSoundService MeuhSoundService { get; set; }
    }
}
