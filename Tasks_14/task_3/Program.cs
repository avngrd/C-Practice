﻿using System;
using task_3;

namespace MyNamespace
{
    delegate void MyEventHandler();
    class Program
    {

        public static void Main()
        {
           Console.WriteLine("Введите имя");
           string enteredString = Console.ReadLine();

            MyInfo information = new MyInfo(enteredString);
            Listener listenerKolya = new Listener("Kolya");
            information.Action += Information_Action;
            information.Action += listenerKolya.Listen;
            while (true)
            {
                information.Name = enteredString;
                Console.WriteLine("Введите имя");
                enteredString = Console.ReadLine();
            }

            Console.WriteLine();
        }

        private static void Information_Action(string obj)
        {
            Console.WriteLine($"Basic action: {obj}");
        }
    }
}