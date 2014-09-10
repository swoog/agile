using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz
{
    public class ResultatViewModel : BaseViewModel
    {
        public ResultatViewModel()
        {
            this.Level = App.QuizzPoints.ToString();
        }

        public string Level { get; set; }
    }
}
