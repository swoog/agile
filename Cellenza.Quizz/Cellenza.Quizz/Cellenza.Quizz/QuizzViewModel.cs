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
        }

        public ICommand AnswerCommand
        {
            get
            {
                return new Command<Reponse>(
                    r =>
                        {
                            App.AnswerQuizz(r.Points);
                        

                            if (App.QuestionAnswered < 10)
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
    }
}
