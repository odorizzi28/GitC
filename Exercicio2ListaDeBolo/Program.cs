using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2ListaDeBolo
{
    class Program
    {
        static void Main(string[] args)
        {
            SejaBemVindo();

            Ingredientes();
       
            ModoDePreparo();
            Animation();

        }
        /// <summary>
        /// Metodo de boas vindas
        /// </summary>
       public static void SejaBemVindo()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("********************* Bem vindo ao Sistema  *******************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("***********************  RECEITA DE BOLO  *********************");
            Console.WriteLine("***************************************************************");
            

            Console.ReadKey();
        }

       public static void Ingredientes()
        {

            Console.Clear();
            Console.WriteLine("***************************************************************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("*******************       iNGREDIENTES       ******************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("2 xícaras (chá) de açúcar");
            Console.ReadKey();
            Console.WriteLine("3 xícaras (chá) de farinha de trigo");
            Console.ReadKey();
            Console.WriteLine("4 colheres (sopa) de margarina");
            Console.ReadKey();
            Console.WriteLine("3 ovos");
            Console.ReadKey();
            Console.WriteLine("1 e 1/2 xícara (chá) de leite");
            Console.ReadKey();
            Console.WriteLine("1 colher (sopa) bem cheia de fermento em pó");
            Console.ReadKey();

        }

        public static void ModoDePreparo()
        {
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("******************       MODO DE PREPARO    ********************");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("****************************************************************");
            
            Console.WriteLine(" 1- Bata as claras em neve e reserve.");
            Console.ReadKey();
            Console.WriteLine(" 2- Misture as gemas, a margarina e o açúcar até obter uma massa homogênea.");
            Console.ReadKey();
            Console.WriteLine(" 3- Acrescente o leite e a farinha de trigo aos poucos, sem parar de bater.");
            Console.ReadKey();
            Console.WriteLine(" 4- Por último, adicione as claras em neve e o fermento.");
            Console.ReadKey();
            Console.WriteLine(" 5- Despeje a massa em uma forma grande de furo central untada e enfarinhada.");
            Console.ReadKey();
            Console.WriteLine(" 6- Asse em forno médio 180 °C, preaquecido, por aproximadamente 40 minutos ou\n" +
                " ao furar o bolo com um garfo, este saia limpo.");

            Console.ReadKey();
        }

        public static void Animation()
        {
            Console.Clear();
            Console.WriteLine("      ********************************************************************");
            Console.WriteLine("      **                             ( )                                 *");
            Console.WriteLine("      **                              |                                  *");
            Console.WriteLine("      **                             |*|                                 *");
            Console.WriteLine("      **                             |*|                                 *");
            Console.WriteLine("      **                             |*|                                 *");
            Console.WriteLine("      **                             |*|                                 *");
            Console.WriteLine("      **                    ********************                         *");
            Console.WriteLine("      **                  *************************                      *"); 
            Console.WriteLine("      **                ******************************                   *");
            Console.WriteLine("      **                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                   *");
            Console.WriteLine("      **                ##############################                   *");
            Console.WriteLine("      **                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                   *");
            Console.WriteLine("      **                ##############################                   *");
            Console.WriteLine("      **                @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@                   *");
            Console.WriteLine("      **                ##############################                   *");
            Console.WriteLine("      ********************************************************************");

        }
    }
}
