using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter String : ");
            string str = Console.ReadLine();

            Console.WriteLine($"{str} -> {str.Length}");

            Console.Write("\nEnter Sentence : ");
            string sen = Console.ReadLine();

            if(sen.EndsWith("."))
            {
                Console.WriteLine("-> Declarative Sentence");
            }
            else if(sen.EndsWith("?"))
            {
                Console.WriteLine("-> Interrogatory Sentence");
            }
            else if(sen.EndsWith("!"))
            {
                Console.WriteLine("-> Exclamation Sentence");
            }
            else
            {
                Console.WriteLine("-> Not a Sentence");
            }

            Console.Write("\nEnter Your Name : ");
            string name = Console.ReadLine();

            string [] words = name.Split(" ");
            Console.Write($"Name : ");

            for(int i = words.Length - 1; i >=0 ; i--)
            {
                Console.Write(words[i]);
                if(i>0){Console.Write(" , ");}
            }
        }
    }
}
