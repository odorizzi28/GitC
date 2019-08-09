using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar Idade");

            var idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem Barba? SIM(1) | NÃO (0):");

            var barba = int.Parse(Console.ReadLine());

            if (idade >= 18 || barba == 1)
            {
                Console.WriteLine("Ambev Aprova");
            }
            
            else

            {
                Console.WriteLine("Vishh");
            }
            Console.ReadKey();
        }
    }
}
