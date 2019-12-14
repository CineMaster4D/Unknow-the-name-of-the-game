using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    class Character
    {
        public string Nickname;
        public int HealthPoint;

        public void Display(string Name, int Health)
        {
            Console.WriteLine(Name + " " + Health);
        }
    }
}
