using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redo_of_Roshambo
{
    class HumanPlayer : Player
    {
        //HumanPlayer - Allows the user to select and throw a value.

        public override Roshambo GenerateRoshambo()
        {
            foreach (int i in Enum.GetValues(typeof(Roshambo)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Roshambo), i)}");

            }

            int humanChoice = -1;

            Console.WriteLine("Enter the number that matches your choice from the list above.");
            int input = int.Parse(Console.ReadLine());
            humanChoice = (int)(Roshambo)input;
            Console.WriteLine($"You chose {humanChoice}.");

            //shouldn't hit this, just making Visual Studio happy
            return Roshambo.scissors;



        }
    }
}
