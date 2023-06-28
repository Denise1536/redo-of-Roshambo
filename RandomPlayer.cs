using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redo_of_Roshambo
{
    internal class RandomPlayer : Player
    {
        //RandomPlayer - Picks and throws a value at random


        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int returnValue = random.Next(1, 3);

            return (Roshambo)returnValue;
        }

    }
}
