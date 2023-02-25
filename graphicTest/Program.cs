using System;

namespace graphicTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(win wins = new win()) 
            {
                wins.Run();            
            }
        }
    }
}