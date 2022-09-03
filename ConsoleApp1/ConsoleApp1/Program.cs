using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sozu daxil edin:");
            string word = Console.ReadLine();
           HelloWorld(word);
        }static void HelloWorld(string word)
        {for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(word); ;
            }
        }
    }
}
