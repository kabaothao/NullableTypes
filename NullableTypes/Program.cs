// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault " + date.HasValue);
            Console.WriteLine("HasValue: " + date.Value);
            Console.WriteLine("Value: " + date.Value);


        }
    }
}