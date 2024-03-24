using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Interfaces
{
    internal interface IGame
    {
        public void GetGameSettings();
        public void PlayGame();
    }
}
