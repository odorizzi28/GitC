using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaCompactando.Biblioteca
{
    class Lista
    {
        string[] lista;
        public Lista()
        {
            //iniciando lista de string com array linear
            lista = new string[10];//definimos as posições da lista iniciando com 10
        }
        public void AumentaLista(int novoTamanho)
        {
            lista = new string[novoTamanho];

        }
        public void CarregaInformacao()
        {
            
            //Laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
            //carregando os calores da lista aqui
            //aonde "i" representa cada espaco que temos disponivel
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:ss.fff");
                //datetime é um tipodo .net c# que disponibiliza funcções relacionadas a data
                //e horas, ou seja se precisar trabalhar com essas informações é possicvel usar esse cara.
            }
        }

        public void ListarInfo()
        {
            // laco de repeticao 
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void LimpaInfo()
        {

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;// aqui limpamos o nosso valor dentro da coleção
            //laço de repetição que usamos para para varrer nossa lista de maneira mais simples
            foreach (var item in lista)
            //indica a lista que desejamos varrer
            {
                Console.WriteLine(item);

            }
        }



    }
}
