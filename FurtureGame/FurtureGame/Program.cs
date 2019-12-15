using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Bot bot = new Bot();

            person.Nickname = "Vex";
            person.HealtPoint = 100;

            bot.Nickname = "WIN.alex";
            bot.HealtPoint = 30;

            person.DisplayInformation();
            bot.DisplayInformation();
            
            Console.ReadLine();
        }
    }
}
