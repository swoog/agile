using Cellenza.Quizz.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cellenza.Quizz.Models;
using Cellenza.Quizz.Repositories;
using Xamarin.Forms;

namespace Cellenza.Quizz
{
    public class App
    {
        public static Page GetPage<TPage, TViewModel>()
            where TPage : Page, new()
            where TViewModel : BaseViewModel, new()
        {
            //var view = new TPage();
			var view = new NavigationPage (new TPage());
            var vm = new TViewModel();
            view.BindingContext = vm;	
			vm.Navigation = view.Navigation;

            return view;
        }

        private static int _questionIndex;
        private static Question[] _questions;

        private const int numberQuestions = 10;

        public static void RestartQuizz()
        {

            _questionIndex = 0;
            QuizzPoints = 0;
            var repo = new QuestionsRepository();
            var rand = new Random();


            var allQuestions = repo.GetAll().ToArray();

            for (int i = 0; i < 30; ++i)
            {
                var randNumber = rand.Next(allQuestions.Length);

                var q1 = allQuestions[0];
                var q2 = allQuestions[randNumber];

                allQuestions[0] = q2;
                allQuestions[randNumber] = q1;
            }

            _questions = allQuestions.Take(numberQuestions).ToArray();
        }

        public static void AnswerQuizz(int points)
        {
            QuizzPoints += points;
            _questionIndex++;
        }

        public static Question CurrentQuestion
        {
            get { return _questions[_questionIndex]; }

        }

        public static Page GetStartPage()
        {
            return GetPage<MainPage, MainViewModel>();
        }

        public static int QuizzPoints { get; private set; }

        public static int QuestionAnswered
        {
            get { return _questionIndex; }
        }

        public static IMeuhSoundService MeuhSoundService { get; set; }

        public static bool IsAllQuestionsAnswered()
        {
            return QuestionAnswered < numberQuestions;
        }
    }
}
