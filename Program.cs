using System;

namespace ReverseString
{
    public class Program
    {
        public static string mirror(string name1)
        {
            string reverse = name1;
            string word = ""; 
            for (int i = 1; i <= reverse.Length; i++)
            {
                word += reverse[reverse.Length - i];
            }
            return word;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(mirror("Jason"));
        }
    }
}
