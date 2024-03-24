using GuessNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Game : IGame
    {
        private readonly IGameSettings GameSettings;
        /// <summary>
        /// Dependency injection
        /// </summary>
        /// <param name="gameSettings"></param>
        public Game(IGameSettings gameSettings) 
        {
            GameSettings = gameSettings;
        }

        public void GetGameSettings()
        {
            ISetting setting = new Setting();
            GameSettings.MinRange = setting.ReadSetting("Insert min number of range");
            GameSettings.MaxRange = setting.ReadSetting("Insert max number of range");
            GameSettings.AttemptsNum = setting.ReadSetting("Insert number of attempts");
        }

        /// <summary>
        /// Open close principal
        /// </summary>
        public void PlayGame()
        {
            GetGameSettings();
            var rand = new Random();
            var guessingDigit = rand.Next(GameSettings.MinRange, GameSettings.MaxRange);
            for (int i = 0; i < GameSettings.AttemptsNum; i++)
            {
                Console.WriteLine("Insert number");
                int.TryParse(Console.ReadLine(), out int insNum);
                if (insNum > guessingDigit)
                {
                    Console.WriteLine("Inserted number greater than guess number");
                }
                else if (insNum < guessingDigit)
                {
                    Console.WriteLine("Inserted number less than guess number");
                }
                else if (insNum == guessingDigit)
                {
                    Console.WriteLine("You win!");
                    break;
                }
                else if(i == GameSettings.AttemptsNum - 1)
                {
                    Console.WriteLine("You lose!");
                }
            }
        }
    }
}
