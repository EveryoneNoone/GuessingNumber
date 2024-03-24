using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber.Interfaces
{
    /// <summary>
    /// Interface segregation principle
    /// </summary>
    internal interface IGameSettings
    {
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
        public int AttemptsNum { get; set; }
    }
}
