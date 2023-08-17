﻿using System;

namespace ucgen_cizme
{
    public class TriangleDrawer
    {
        public static void DrawTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgen boyutu: ");
            int size = int.Parse(Console.ReadLine());

            TriangleDrawer.DrawTriangle(size);
        }
    }
}
