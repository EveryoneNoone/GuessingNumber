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
    public interface ISetting
    {
        public int ReadSetting(string settingMessage);
    }
}
