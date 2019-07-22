using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool translateAgain = true, hasVowel = true;
            while (translateAgain)
            {
                string english = GetString("Give me a word to translate to Pig Latin.");
                hasVowel = CheckForVowel(english);
                if (hasVowel == true)
                {
                    int vowelLoation = CheckVowelLocation(english);
                    Console.WriteLine($"Pig Latin: {MakePigLatinVowel(vowelLoation, english)}");
                }
                else
                {
                    Console.WriteLine($"Pig Latin: {MakePigLatinConsonant(english)}");
                }
                translateAgain = TranslateAgain("Would you like to translate another word?");
            }
            Console.WriteLine("Goodbye.");
        }


        public static bool CheckForVowel(string english)
        {
            bool check = true;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char vowel in vowels)
            {
                check = english.Contains(vowel);
                if(check == true)
                {
                    return check;
                }
            }
            return false;
        }
        public static int CheckVowelLocation(string english)
        {
            int location;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char vowel in vowels)
            {
                bool check = english.Contains(vowel);
                if (check == true)
                {
                    return location = english.IndexOfAny(vowels);
                }
            }
            return CheckVowelLocation(english);
        } 
        public static string MakePigLatinVowel(int location, string english)
        {
            string pigLatin = "", subEnglish = "", newEnglish = "";

                subEnglish = english.Substring(location);
                newEnglish = english.Substring(0, location);
                return pigLatin = string.Concat(subEnglish, newEnglish) + "ay";
        }
        public static string MakePigLatinConsonant(string english)
        {
            return english + "way";
        }
        public static string GetString(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^[a-zA-Z]*[']*[a-zA-Z]*$"))
            {
                string word = input.ToLower();
                return word;
            }
            else
            {
                return GetString(message);
            }
        }
        public static bool TranslateAgain(string message)
        {
            Console.WriteLine(message);
            string yesNo = Console.ReadLine().ToLower();
            if (yesNo == "y")
            {
                return true;
            }
            if (yesNo == "n")
            {
                return false;
            }
            else
            {
                return TranslateAgain(message);
            }
        }
    }
}


