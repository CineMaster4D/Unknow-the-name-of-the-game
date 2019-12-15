using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurtureGame
{
    class Character
    {
        public string Nickname { get; private set; }
        public int HealtPoint { get; private set; }

        public int X { get; private set; }
        public int Y { get; private set; }

        public Character(string nickname, int healtPoint)
        {
            Nickname = nickname;
            HealtPoint = healtPoint;

            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();

            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{Nickname} ({X}), ({Y})";
        }
    }
}
