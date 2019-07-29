using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <t> o tipo da minha lista com isso temos uma lista de lanchhe
            List<Lanche> minhaLista = new List<Lanche>();
            {
                
                //adiciono na minha lista um pao de queijo
                minhaLista.Add(new Lanche()
                {
                    Nome = "Pão de Queijo",
                    Quantidade = 9,
                    Valor = 1.85
                });

                minhaLista.Add(new Lanche()
                {
                    Nome = "Bolinho de Soya + Refri Bonus: Gastrite",
                    Quantidade = 2,
                    Valor = 7.50
                });

                minhaLista.Add(new Lanche()
                {
                    Nome = "Pastel",
                    Quantidade = 3,
                    Valor = 3.50
                });

      

                //aqui ando pela minha lista para poder apresentar em tela os valores 
                //item in significa que elaja é um indice da minha lista bonitinho
                foreach (Lanche item in minhaLista)
                    Console.WriteLine($"Lanches disponiveis: {item.Nome}");




             //       Console.WriteLine("Removendo Item");

             //   foreach (Lanche item in minhaLista)
             //   {
             //       if (item.Quantidade == 2)
             //           minhaLista.Remove(item);
             //       break;
             //   }
             //
             //   foreach(Lanche item in minhaLista)
             //       Console.WriteLine($"Lanches disponiveis: {item.Nome}");

                Console.ReadKey();
            }
           
        }




    }
}
