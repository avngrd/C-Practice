﻿using System.Text;
namespace MyNamespace
{
    class Program
    {
        public static void Main()
        {
            int a = 2, b = 6;
            int number;
          
            Queue<int> fromAToB = new Queue<int>();
            Queue<int> lessThenA = new Queue<int>();
            Queue<int> moreThenB = new Queue<int>();

            using (StreamReader reader = new StreamReader(@"file.txt", Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    number = 5;

                    if (number < a)
                        lessThenA.Enqueue(number);
                    else if (number > b)
                        moreThenB.Enqueue(number);
                    else
                        fromAToB.Enqueue(number);
                }
            }
            Console.WriteLine(string.Join(" ", fromAToB));
            Console.WriteLine(string.Join(" ", lessThenA));
            Console.WriteLine(string.Join(" ", moreThenB));
        }
    }
}