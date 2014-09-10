using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz
{
    using System.Collections.ObjectModel;

    using Cellenza.Quizz.QuestionRead;

    public class QuizzViewModel : BaseViewModel
    {
        public string QuestionText { get; set; }

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

        }
    }

    public class Response
    {
        public string Value { get; set; }

        public int Points { get; set; }
    }
}
