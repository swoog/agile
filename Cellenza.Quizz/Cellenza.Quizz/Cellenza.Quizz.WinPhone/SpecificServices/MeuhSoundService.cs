using Cellenza.Quizz.Services;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz.WinPhone.SpecificServices
{
    public class MeuhSoundService : IMeuhSoundService
    {

        public void Play()
        {

            Stream stream1 = TitleContainer.OpenStream("Meuh1.wav");

            SoundEffect sfx = SoundEffect.FromStream(stream1);

            SoundEffectInstance soundEffect = sfx.CreateInstance();

            FrameworkDispatcher.Update();

            soundEffect.Play();
        }
    }
}
