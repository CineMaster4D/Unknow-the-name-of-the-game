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

            person.Nickname = "Anatola";
            person.HealthPoint = 100;

            bot.Nickname = "Wolf";
            bot.HealthPoint = 30;

            person.Display(person.Nickname, person.HealthPoint);
            bot.Display(bot.Nickname, bot.HealthPoint);
            Console.ReadLine();
        }
    }
}
