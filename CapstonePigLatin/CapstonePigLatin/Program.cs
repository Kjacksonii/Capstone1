using System;
using System.Linq;

namespace CapstonePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Would you like to convert to Pig Latin? y/n");
                string userInput = Console.ReadLine().ToLower();
                while (userInput == "y")
                {

                    Console.WriteLine("Enter a word or sentence.");
                    String str = Console.ReadLine().ToLower();
                    String[] Words = str.Split(new char[] { ' ' });
                    String PigLat = "";

                    foreach (string word in Words)
                    {
                        String CurrentWord = word;

                        char FirstLetter = CurrentWord.ToLower()[0];

                        CurrentWord = CurrentWord.Remove(0, 1);
                        CurrentWord = CurrentWord.Insert(CurrentWord.Length, FirstLetter.ToString());

                        if (IsConsonant(FirstLetter))
                        {
                            CurrentWord = CurrentWord.Insert(CurrentWord.Length, "ay");
                        }
                        else { CurrentWord = CurrentWord.Insert(CurrentWord.Length, "way"); }
                        PigLat = PigLat.Insert(PigLat.Length, CurrentWord + " ");
                    }

                    Console.WriteLine(PigLat.Remove(PigLat.Length - 1).ToLower());
                    Console.WriteLine("Would you like to convert to Pig Latin? y/n");
                    userInput = Console.ReadLine();

                    if (userInput == "n")
                    {
                        System.Environment.Exit(1);
                    }
                }
            }
        }

        static bool IsConsonant(char letter)
        {

            char[] Vowels = { 'A', 'E', 'I', 'O', 'U' };

            if (Vowels.Contains(letter))
            { return false; }
            else
            {
                return true;
            }

        }
    }
}
    
