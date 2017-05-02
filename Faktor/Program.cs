using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int articles = int.Parse(inputs[0]);
            
            Console.WriteLine((int.Parse(inputs[1]) * articles) - (articles -1));            
        }
    }
}
