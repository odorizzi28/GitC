using Listar_meus_carros.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)

        {
            MostrarMenu();
            var op = MostrarMenu();
            while (op != 3)
            {
                if (op == 1)
                Listar();
                if (op == 2)
                ListAdd();

                op = MostrarMenu();
            }

        }
          public static int MostrarMenu()
            {
                Console.Clear();
                Console.WriteLine("-----Sistema de Listar meus Carros---------");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("------------(1) LISTAR OS CARROS-----------");
                Console.WriteLine("------------(2) ADICIONAR CARROS-----------");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("------------(3) SAIR DO SISTEMA------------");
                Console.WriteLine("-------------------------------------------");
                int.TryParse(Console.ReadLine(), out int opcao);

                return opcao;
            }




        public static string RetornaValores(string modelo)
            {//informo e retorno o valor conforme a solicitação do campo
                Console.WriteLine($"Informe o valor para o campo:{modelo}");
                return Console.ReadLine();
            }

        public static void ListAdd()
            {
                List<Carros> lista = new List<Carros>();
                for (int i = 0; i < 1; i++)
                {
                    lista.Add(new Carros()
                    {
                        Modelo = RetornaValores("modelo"),
                        Placa = RetornaValores("Placa"),
                        Ano = int.Parse(RetornaValores("Ano")),
                        Cv = int.Parse(RetornaValores("Cavalos"))

                    });

                foreach (Carros item in lista)
                    Console.WriteLine($"Modelo:{item.Modelo}\r\nPlaca:{item.Placa}\r\nAno:{item.Ano}\r\nCavalos:{ item.Cv}");
                Console.ReadLine();

            }
            }
        public static void Listar()
        {
            
                

        }

    }
    }

        
    

