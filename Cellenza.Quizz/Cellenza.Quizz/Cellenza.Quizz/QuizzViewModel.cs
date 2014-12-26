using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    using Cellenza.Quizz.Models;
    using Cellenza.Quizz.Repositories;

    using Xamarin.Forms;

    public class QuizzViewModel : BaseViewModel
    {
        public string QuestionText { get; set; }

        public string Level { get; set; }

        public ObservableCollection<Reponse> Responses { get; set; }

        public QuizzViewModel()
        {

            var question = App.CurrentQuestion;

            this.QuestionText = question.Text;
            this.Responses = new ObservableCollection<Reponse>(question.Answers);

            this.Level = App.QuizzPoints.ToString();
            this.LevelWidth = App.QuizzPoints * 300.0 / 40.0;
        }

        public double LevelWidth { get; set; }

        public ICommand AnswerCommand
        {
            get
            {
                return new Command<Reponse>(
                    r =>
                        {
                            App.AnswerQuizz(r.Points);
                        

                            if (App.IsAllQuestionsAnswered())
                            {
                                this.Navigation.PushAsync(App.GetPage<QuizzPage, QuizzViewModel>());
                            }
                            else
                            {
                                this.Navigation.PushAsync(App.GetPage<Resultat, ResultatViewModel>());
                            }
                        });
            }
        }

        public bool T1Visibility
        {
            get { return App.QuizzPoints < 5; }
        }

        public bool T2Visibility
        {
            get { return App.QuizzPoints <= 10 && App.QuizzPoints > 5; }
        }

        public bool T3Visibility
        {
            get { return App.QuizzPoints <= 15 && App.QuizzPoints > 10; }
        }

        public bool T4Visibility
        {
            get { return App.QuizzPoints <= 20 && App.QuizzPoints > 15; }
        }

        public bool T5Visibility
        {
            get { return App.QuizzPoints <= 24 && App.QuizzPoints > 20; }
        }

        public bool T6Visibility
        {
            get { return App.QuizzPoints <= 27 && App.QuizzPoints > 24; }
        }

        public bool T7Visibility
        {
            get { return App.QuizzPoints <= 30 && App.QuizzPoints > 27; }
        }

        public bool T8Visibility
        {
            get { return App.QuizzPoints <= 34 && App.QuizzPoints > 30; }
        }

        public bool T9Visibility
        {
            get { return App.QuizzPoints <= 37 && App.QuizzPoints > 34; }
        }

        public bool T10Visibility
        {
            get { return App.QuizzPoints > 37; }
        }
    }
}
