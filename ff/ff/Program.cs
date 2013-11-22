using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int number;
            if(int.TryParse(str,out number))
                Console.WriteLine("da");
            Console.WriteLine(number);
        }
    }
}
