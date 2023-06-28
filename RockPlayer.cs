using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redo_of_Roshambo
{
    internal class RockPlayer : Player
    {
        //RockPlayer - Always throws Rock
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
