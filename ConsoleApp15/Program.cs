﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет создатель, как тебя зовут?");
            string answeruser = Console.ReadLine();
            Console.WriteLine("а как ты назовешь меня");
            string namebot = Console.ReadLine();
            Console.WriteLine($"Приятно познакомится {answeruser}. Меня зовут {namebot}- это ты меня так назвал");
        }
    }
}
