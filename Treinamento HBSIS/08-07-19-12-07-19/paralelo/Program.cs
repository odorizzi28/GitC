using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBibliotecaOnline
{
    class Program
    {
        static string[,] baseDeCarro;
        static void Main(string[] args)
        {
            carregaBaseDeDados();
            MostrarSejaBemVindo();
            var OpcaoMenu = MenuPrincipal();

            while (OpcaoMenu!= 3)
            {
                if (OpcaoMenu == 1)
                    AlocarCarro();

              //  if (OpcaoMenu == )
                   // Desa();

                OpcaoMenu = MenuPrincipal();
            }

         
            Console.ReadKey();
        }

        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("###############################################################");
            Console.WriteLine("##            Sistema de Alocação de Carros                  ##");
            Console.WriteLine("###############################################################");

        }
        public static int MenuPrincipal()
        {
            Console.WriteLine("     Menu Inicial");
            Console.WriteLine("\r\nDigite 1 para alocar Carro.");
            Console.WriteLine("\r\nDigite 2 para Deslocar Carro");
            Console.WriteLine("\r\nDigite 3 para Sair do sistema ");


            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);
            return opcao;

        }

        public static void carregaBaseDeDados()
        {
            baseDeCarro = new string[2, 3]
           {
              {"Celta","2018","sim"},
              { "Civic","2018","sim"}
           };
        }
      
        public static bool PesquisaCarro(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarro.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarro[i, 0])
                {
                    Console.WriteLine($"O Carro :{ nomeCarro}" +
                            $" pode ser alocado?: {baseDeCarro[i, 1]}");
                    return baseDeCarro[i, 2] == "sim";
                }
            }
            return false;
        }
      
        public static void AlocarCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < baseDeCarro.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarro[i, 0])
                {
                   
                    baseDeCarro[i, 1] = alocar ? "não" : "sim";
                }
                    
            }
        }

        public static void MostrarMenuAlocacao()
        {
            Console.Clear();
            MostrarSejaBemVindo();

            Console.WriteLine("\r\nMenu - Alocação de Carro");
            MostraCarroDisponivel();
            Console.WriteLine("\r\nDigite o nome do Carro a ser alocado");
            var nomedoCarro = Console.ReadLine();

            if (PesquisaCarro(nomedoCarro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o Carro? Para sim (1) para não (0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    //AlocarCarro(nomedoCarro);
                    Console.Clear();
                    Console.WriteLine("Carro Alocado com Sucesso:");
                }
                else
                    Console.Clear();
                    Console.WriteLine("Listagem de Carro:");

                for (int i = 0; i < baseDeCarro.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeCarro[i, 0]} Ano :{baseDeCarro[i, 1]} Disponivel: {baseDeCarro[i,2]} ");
                    
                }
                MostrarMenuAlocacao();

                
                

            }
        }

        public static void MostraCarroDisponivel()
        {
            for (int i = 0; i < baseDeCarro.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeCarro[i, 0]} Ano :{baseDeCarro[i, 1]} Disponivel: {baseDeCarro[i, 2]} ");
            }
                
        }

       public static void AlocarCarro()
        {
            var nomedocarro = Console.ReadLine();
        }
    }

}


