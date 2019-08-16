using CriacaoDeListaCompactando.Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaCompactando
{
    class Program
    {
        static void Main(string[] args)
        {

            var lista = new Lista();
            lista.CarregaInformacao();
            lista.ListarInfo();
            lista.LimpaInfo();
            lista.AumentaLista(50);
            lista.CarregaInformacao();
            lista.ListarInfo();
            lista.LimpaInfo();
            Console.ReadKey();


        }
    }
}
