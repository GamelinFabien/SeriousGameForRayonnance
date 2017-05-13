using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriousGameRayonnance.Utils;

namespace SeriousGameRayonnance.Models
{
    //here I will read the text file and try to get all the words
    class WordDictionnary
    {
        List<string> Words;
        public List<string> getWords()
        {
            Tools tool = new Tools();
            Words = tool.ReadFile("google1000.txt");
            //Here we got all the words
            foreach(string w in Words)
            {
                Console.Write(w);
            }
            return Words;
        }

        public List<string> get()
        {
            return Words;
        }
    }
}
