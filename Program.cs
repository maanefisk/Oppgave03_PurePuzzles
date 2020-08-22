using System;
using System.Data;

namespace Oppgave03_PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = " ";
            int x = 8;

            for (int b = 0; b < 4; b++)
            {
                for (int c = 0; c < b; c++)
                {
                    Console.Write(space);
                }
                
                for (int a = 0; a < x; a++)
                {
                    string rowofhash = "#";
                    Console.Write(rowofhash);
                }

                x = x - 2;

                Console.WriteLine(space);
            }

            
            
        }
    }
}
