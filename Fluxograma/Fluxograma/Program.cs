using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluxograma
{
    class Program
    {
        static void Main(string[] args)
            
        {
           string[,] livros = new string[2, 2] {
           { "O pequeno",//Nome do livro
           "sim" },//Disponivel
           { "O grande",//Nome do Livro }
                "não"// disponivel
           } };
            Console.ReadKey();
        }
        
    }

}
#region
//       {
//       string basee ;
//       string altura;
//           
//           Console.WriteLine("Digite o valor da Base!");
//           basee = Console.ReadLine();
//
//           Console.WriteLine("Digite o valor da Altura!");
//           altura = Console.ReadLine();
//           int BaseConvert = Convert.ToInt32(basee);
//           int AlturaConvert = Convert.ToInt32(altura);
//           Console.WriteLine("Valor total da área: " + BaseConvert * AlturaConvert+" MT²");
//
//           { Console.ReadKey();
//           }
//       }
#endregion