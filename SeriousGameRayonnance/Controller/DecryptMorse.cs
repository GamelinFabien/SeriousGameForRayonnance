using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeriousGameRayonnance.Utils;
using SeriousGameRayonnance.Models;

namespace SeriousGameRayonnance.Controller
{
    //It's in this class we will decrypt the sentence
    class DecryptMorse
    {
        string sentenceCrypt = ".--..-..-.-.-----.-----....--...-.-.-..-....--.-......----.";

        //Dans cette méthode nous allons faire ressortir toutes les lettres possibles présentes
        public List<string> DecryptCaracters()
        {
            string result = "";
            MorseDictionnary morse = new MorseDictionnary();
            IDictionary<string, string> morseletters = morse.get();
            List<string> lettersDecrypt = new List<string>();
            string temp = "";
            string solution = "";

            //I will compare caracters by caracters in the sentence with my morse dictionnary 
            //I will get all possible letters
            foreach (var c in sentenceCrypt)
            {
                if (morseletters.Keys.Contains(string.Concat(c.ToString(), temp)))
                {
                    temp = string.Concat(c.ToString(), temp);
                    morseletters.TryGetValue(string.Concat(c.ToString(), temp), out solution);
                    lettersDecrypt.Add(solution);
                }

                else if (morseletters.Keys.Contains(c.ToString()))
                {
                    temp = c.ToString();
                }
            }

            return lettersDecrypt;
        }

        //Compare caracters and try to make the most of words
        public void MakeSentence()
        {
            WordDictionnary _words = new WordDictionnary();
            List<string> words = _words.get();
            List<string> letters = DecryptCaracters();

            // HERE IF I'D HAVE MORE TIME
            //I wwould make an algorithm in order ton concat each solutions of letters, and compare with all the words
            //And finally to find multiple solutions
            foreach (var l in letters)
            {
                foreach (var w in words)
                {

                }
            }


        }
    }
}
