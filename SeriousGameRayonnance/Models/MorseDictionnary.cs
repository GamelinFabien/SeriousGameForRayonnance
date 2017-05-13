using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriousGameRayonnance.Models
{
    //Here I create a class where I'll have all the morse letters, in order to use them in my program
    class MorseDictionnary
    {
        public Dictionary<string, string> MorseLetters;

        public MorseDictionnary()
        {
            MorseLetters = new Dictionary<string, string>();

            MorseLetters.Add(".-", "A");
            MorseLetters.Add("-...", "B");
            MorseLetters.Add("-.-.", "C");
            MorseLetters.Add("-..", "D");
            MorseLetters.Add(".", "E");
            MorseLetters.Add("..-.", "F");
            MorseLetters.Add("--.", "G");
            MorseLetters.Add("....", "H");
            MorseLetters.Add("..", "I");
            MorseLetters.Add(".---", "J");
            MorseLetters.Add("-.-", "K");
            MorseLetters.Add(".-..", "L");
            MorseLetters.Add("--", "M");
            MorseLetters.Add("-.", "N");
            MorseLetters.Add("---", "O");
            MorseLetters.Add(".--.", "P");
            MorseLetters.Add("--.-", "Q");
            MorseLetters.Add(".-.", "R");
            MorseLetters.Add("...", "S");
            MorseLetters.Add("-", "T");
            MorseLetters.Add("..-", "U");
            MorseLetters.Add("...-", "V");
            MorseLetters.Add(".--", "W");
            MorseLetters.Add("-..-", "X");
            MorseLetters.Add("-.--", "Y");
            MorseLetters.Add("--..", "Z");

        }

        public Dictionary<string, string> get()
        {
            return MorseLetters;
        }
    }
}
