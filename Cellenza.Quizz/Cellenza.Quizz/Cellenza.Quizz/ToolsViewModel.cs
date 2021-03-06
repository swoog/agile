﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cellenza.Quizz
{
    public class ToolsViewModel : BaseViewModel
    {
        public ToolsViewModel()
        {
            MeuhViewModel = new MeuhViewModel();
        }

        public MeuhViewModel MeuhViewModel
        {
            get;
            private set;
        }

        public ICommand MeuhCommand
        {
            get
            {
                return new Command(() =>
                {
                    MeuhViewModel.Meuh();
                });
            }
        }

    }
}
