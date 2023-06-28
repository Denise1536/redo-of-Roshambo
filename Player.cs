using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redo_of_Roshambo
{
    abstract class Player
    {
        //Create an abstract class named Player that stores a name and a Roshambo value. This
        //class should include a method named GenerateRoshambo that allows an inheriting
        //class to generate and return a Roshambo value.

        string Name { get; set; }
        int RoshamboValue { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
