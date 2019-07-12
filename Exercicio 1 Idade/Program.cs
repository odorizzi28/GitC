using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string Nome;
            Console.WriteLine("Digite seu nome");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            idade= int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine(Nome + " Autorizado consumir bebidas alcoólicas");
            }
            else
                Console.WriteLine(Nome+ " Não autorizado consumir bebidas alcoólicas");

            Console.ReadKey();
        }
        
    }

    
}
