using System;
using System.Data;

namespace Oppgave03_PurePuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rowofhash = "";
            string space = " ";

            for (int b = 0; b < 4; b++)
            {
                for (int a = 0; a < 8; a++)
                {
                    rowofhash = "#";
                            Console.Write(rowofhash);
                }

                Console.WriteLine(space);
            }

            
            
        }
    }
}
