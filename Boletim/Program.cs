using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 


namespace Boletim
{
    class Program
    {
        static void Main(string[] args)
        {
            boletim boletim = new Boletim();
            Console.WriteLine("Informe uma nota ");
            var nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe uma nota ");
            var nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe uma nota ");
            var nota3 = Convert.ToInt32(Console.ReadLine());

            var media = boletim.medias(nota1, nota2, nota3);
            var frequencia = boletim.frequencia(100, 10);

            boletim.situacao(media, frequencia);
            Console.ReadKey();


            Console.ReadKey();
        }
        
    }

}
