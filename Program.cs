using System;
using System.Data;

namespace Oppgave03_PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int b = 0; b < 4; b++)
            { 
                for (int a = 0; a < 8; a++) 
                {
                            Console.Write("#");
                }
                for (int c = 0; c < 8; c++)
                {
                    Console.Write("S");
                }
                Console.WriteLine("M");
            }

            
            
        }
    }
}
