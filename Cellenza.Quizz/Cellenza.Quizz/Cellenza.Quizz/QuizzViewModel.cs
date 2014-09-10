using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    using Cellenza.Quizz.QuestionRead;

    using Xamarin.Forms;

    public class QuizzViewModel : BaseViewModel
    {
        public string QuestionText { get; set; }

        public string Level { get; set; }

        public ObservableCollection<Response> Responses { get; set; }

        public QuizzViewModel()
        {
            this.QuestionText = "Ma question ?";
            this.Responses = new ObservableCollection<Response>()
                                 {
                                     new Response() { Value = "Val1", Points = 0, },
                                     new Response() { Value = "Val2", Points = 1, },
                                     new Response() { Value = "Val3", Points = 2, },
                                     new Response() { Value = "Val4", Points = 3, },
                                 };

            this.Level = App.QuizzPoints.ToString();
        }

        public ICommand AnswerCommand
        {
            get
            {
                return new Command<Response>(
                    r =>
                        {
                            App.QuizzPoints += r.Points;
                            App.QuestionAnswered++;

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

    public class Response
    {
        public string Value { get; set; }

        public int Points { get; set; }
    }
}
