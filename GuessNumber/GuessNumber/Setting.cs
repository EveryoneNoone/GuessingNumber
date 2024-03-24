using GuessNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class Setting : ISetting
    {
        public int ReadSetting(string settingMessage)
        {
            Console.WriteLine(settingMessage);
            int setting;
            while (true)
            {
                try
                {
                    setting = int.Parse(Console.ReadLine());
                    break;
                }
                catch(Exception ex) 
                {
                    Console.WriteLine("Wrong data. Insert correct number! {0}", ex.Message);
                }
            }
            return setting;
        }
    }
}
