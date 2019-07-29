using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    public class ClasseCantina
    {

        public int CompraLanche()
        {

            double saldo = 20;
            int.TryParse(Console.ReadLine(), out int opcao);

            if (opcao == 1 && saldo >= 4)
            {
                Console.WriteLine("Compra realizada com sucesso!");
                Console.WriteLine($"Saldo: " + (saldo = (saldo - 4)));

            }

            Console.WriteLine("Deseja comprar outro produto? Digite o numero que correspode ele");

            int.TryParse(Console.ReadLine(), out int opcao1);

            if (opcao1 == 2 && saldo >= 5)
            {
                Console.WriteLine("Compra realizada com sucesso!");
                Console.WriteLine($"Saldo: " + (saldo = (saldo = (saldo - 5))));
            }
            Console.ReadKey();
            return opcao;

        }



    }
}
