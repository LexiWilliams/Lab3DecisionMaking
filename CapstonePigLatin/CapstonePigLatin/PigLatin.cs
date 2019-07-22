using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstonePigLatin
{
    class PigLatin
    {
        static void Stuff(string[] args)
        {
            string vowels = "AEIOUaeiou";
          
            string[] stuff = { "a", "e", "i", "o", "u" };
            
            bool containsVowel = true;
            containsVowel = stuff.Contains(vowels);
            Console.WriteLine(containsVowel);


        }



    }
}
