using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriousGameRayonnance.Utils;
using SeriousGameRayonnance.Models;
using SeriousGameRayonnance.Controller;

namespace SeriousGameRayonnance
{
    class Program
    {
        static void Main(string[] args)
        {

            DecryptMorse decrypt = new DecryptMorse();
            WordDictionnary word = new WordDictionnary();

            foreach (var d in decrypt.DecryptCaracters())
            {
                Console.WriteLine(d);
            }

            word.getWords();


           // Console.WriteLine(tool.ReadFile("google1000.txt"));
            Console.ReadLine();
        }
    }
}
