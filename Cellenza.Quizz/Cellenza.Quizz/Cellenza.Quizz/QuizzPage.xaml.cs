using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz
{
    using System.ServiceModel.Channels;

    using Xamarin.Forms;

    public partial class QuizzPage
    {
        public QuizzPage()
        {
            InitializeComponent();
        }

        private void AnswerSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var param = e.SelectedItem as Response;
            var command = ((QuizzViewModel)BindingContext).AnswerCommand;

            if (command.CanExecute(param))
            {
                command.Execute(param);
            }
        }

    }
}
