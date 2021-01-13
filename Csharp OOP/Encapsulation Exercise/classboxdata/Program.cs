﻿using System;

namespace classboxdata
{
    class Program
    {
        static void Main(string[] args)
        {
             double length = double.Parse(Console.ReadLine());
             double width = double.Parse(Console.ReadLine());
             double height = double.Parse(Console.ReadLine());

             Box box = null;

             try
             {
                box = new Box(length, width, height);
             }
             catch (ArgumentException e)
             {
                 Console.WriteLine(e.Message);
                 return;
             }


             Console.WriteLine(box);
        }
    }
}
