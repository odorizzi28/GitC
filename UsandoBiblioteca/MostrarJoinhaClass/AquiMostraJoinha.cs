using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    public class AquiMostraJoinha
    {
        /// <summary>
        /// Será que é sexta hoje
        /// </summary>
        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui iniciamos o nosso Joinha");
            Console.ReadKey();
        }

        /// <summary>
        /// Ainda bebe mais que eu
        /// </summary>
        /// <param name="eQuinta">2.0 ainda faz 3 por </param>
        public void MetodoisDoisPOntoZero(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("Cariai Mermão!!!");
            else
                Console.WriteLine("Aiaiaiaiaii!!!");

            Console.ReadKey();

        }

        /// <summary>
        /// Metodo que vamos identifica o tipo
        /// </summary>
        /// <returns>retorna algo?</returns>
        public string[] testeUmOperadorLegal()
        {
            return new string[2] { "Teste1", "Teste @" };
        }
    }
}
