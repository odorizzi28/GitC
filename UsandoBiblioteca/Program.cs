using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            //  new AquiMostraJoinha().MetodoInicialDoJoinha();
            //  new AquiMostraJoinha().MetodoisDoisPOntoZero(true);
            //  new AquiMostraJoinha().MetodoisDoisPOntoZero(false);
            // 

            //Operação pesada como leitura e gravação na memoria
            var outroCaraParaRealizarOTeste = new AquiMostraJoinha().testeUmOperadorLegal();
            var teste = outroCaraParaRealizarOTeste.GetType();
            //Contagem de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizarOTeste.Length;
            // nosso for agora sta mais rapido
            for (int i = 0; i < tamanhoDaLista; i++)
            {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);
            }

            Console.ReadKey();
        }
    }
}
