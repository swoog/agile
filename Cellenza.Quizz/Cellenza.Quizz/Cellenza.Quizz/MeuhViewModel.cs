using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cellenza.Quizz
{
    public class MeuhViewModel : BaseViewModel
    {
        public ICommand MeuhCommand
        {
            get
            {
                return new Command(() =>
                {
                    Meuh();
                });
            }
        }

        public void Meuh()
        {
            App.MeuhSoundService.Play();
        }
    }
}
