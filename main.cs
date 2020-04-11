
using System;
namespace ConsoleApp1
{
    public static class Convertions
    {
         public static string ToAlternativeCase(string word)
             {
                int wordLength = word.Length;
                char[] wordarray = word.ToCharArray();
                char[] result = new char[wordLength];
                for (int i = 0; i < wordLength; i++)
                {
                    bool isTrue = Char.IsUpper(wordarray[i]);
                    if (isTrue == true)
                    {
                        result[i] = Char.ToLower(wordarray[i]);
                    }
                    else
                        result[i] = Char.ToUpper(wordarray[i]);
                }
                string word = new string(result);
                return word;
                   throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Convertions.ToAlternativeCase(word);
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}