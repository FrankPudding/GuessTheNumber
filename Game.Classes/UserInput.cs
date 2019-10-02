using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Classes
{
    public class UserInput
    {
        public UserInput(string input)
        {
            Input = input;
        }

        public string Input { get; set; }
    }
}
