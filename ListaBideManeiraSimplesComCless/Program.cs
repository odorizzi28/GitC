using ListaBideManeiraSimplesComCless.Carrega;
using ListaBideManeiraSimplesComCless.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBideManeiraSimplesComCless
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Aqui iniciamos nosso Objeto em memoria
            var carregaLista = new CarregarLista();
            //aqui chamamos nosso metodo para carregar a lista
            carregaLista.CarregaInformacoesEListaElasEmTela();

            //Carregamos namente mas agota a classe mostra lista aonde colocamos todos os 
            //metodos que serão direcionados para mostrar a listagem de informações na tela
            var mostrarLista1 = new MostrarLista();
            mostrarLista1.PesquisandoInformacoesNaNossaLista(carregaLista.ListaNome,"0");

            Console.ReadKey();
        }
    }
}
