using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando lista de string com array linear
            string[] lista = new string[5];//definimos as posições da lista iniciando com 10
            //Laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
                //carregando os calores da lista aqui
                //aonde "i" representa cada espaco que temos disponivel
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:ss.fff");
                //datetime é um tipodo .net c# que disponibiliza funcções relacionadas a data
                //e horas, ou seja se precisar trabalhar com essas informações é possicvel usar esse cara.
            }
            // laco de repeticao 
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;// aqui limpamos o nosso valor dentro da coleção
            //laço de repetição que usamos para para varrer nossa lista de maneira mais simples
            foreach (var item in lista)
                //indica a lista que desejamos varrer
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
