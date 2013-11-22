using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you should enter a number "+
                "that has an exact square root");
            Console.WriteLine("the number of the symbols is");
            int numberOfSymbols = int.Parse(Console.ReadLine());
            int rows = (int)Math.Sqrt(numberOfSymbols);
            char symbol = '\u00A9';
            int count = 1;
            for (int currentRow = 1; currentRow <= rows; currentRow++)
            {
                for (int space = 0; space < rows-currentRow; space++)
                {
                    Console.Write(" ");
                }
                if (count==1)
                {
                    Console.Write(symbol);
                    count++;
                    Console.WriteLine();
                    continue;                   
                }
                for (int printingSymbol = 1; printingSymbol <= 1+2*(currentRow-1); printingSymbol++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
