using GuessNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    /// <summary>
    /// Single responsibility principle
    /// </summary>
    internal class GameSettings : IGameSettings
    {
        private int minRange;
        private int maxRange;
        private int attemptsNum;
        public int MinRange { get => minRange; set => minRange = value; }
        public int MaxRange 
        { 
            get => maxRange;             
            set 
            {
                if (value < minRange) throw new Exception("Max range must be greater than min range");
                maxRange = value;
            } 
        }
        public int AttemptsNum { get => attemptsNum; set => attemptsNum = value; }
    }
}
