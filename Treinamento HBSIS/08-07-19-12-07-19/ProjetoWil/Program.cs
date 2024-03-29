﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraAmbev
{
    class Program
    {
        static string[,] carros;
        static void Main(string[] args)
        {
            carregarVeiculos();
            mostrarBemVindo();
            pegaOpcao();
        }

        /// <summary>
        /// metodo para identificar pegar o valor da opção escolhida pelo usuario dentro do método que retorna o que o usuario digitou
        /// </summary>
        private static void pegaOpcao()
        {
            int opcao = mostrarMenuLocacao();
            verificaOpcao(opcao);
            if (opcao == 1)
            {
                retornarAoMenu();
            }
        }
        /// <summary>
        /// metodo para retornar ao menu
        /// </summary>
        private static void retornarAoMenu()
        {
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
            mostrarBemVindo();
            pegaOpcao();
        }
        /// <summary>
        /// metodo para verificar a opção escolhida pelo usuario
        /// </summary>
        /// <param name="opcao">Digitado pelo usuario</param>
        private static void verificaOpcao(int opcao)
        {
            if (opcao == 1)
            {
                vizualizarVeiculos();
            }
            else if (opcao == 2)
            {
                alocarVeiculo();
            }
            else if (opcao == 3)
            {
                DesalocarVeiculo();
            }
        }

        private static void DesalocarVeiculo()
        {
            if (atualizarVeiculo(ModeloVeiculoSolicitado("desalocar"), "desalocar"))
            {
                Console.WriteLine("Veiculo deslocado com sucesso!! ");
                retornarAoMenu();
            }
            else
            {
                Console.Clear();
                mostrarBemVindo();
                Console.WriteLine("Ops, não foi possibvel deslocar o veiculo digitado, verifique se esta correto!");

                pegaOpcao();
            }
        }

        /// <summary>
        /// metodo para iniciar a locação do veiculo
        /// </summary>
        private static void alocarVeiculo()
        {

            if (atualizarVeiculo(ModeloVeiculoSolicitado("alocar"), "alocar"))
            {
                Console.WriteLine("Veiculo locado com sucesso!! ");
                retornarAoMenu();
            }
            else
            {
                Console.Clear();
                mostrarBemVindo();
                Console.WriteLine("Ops, algo deu errado, não foi possivel encontrar o veiculo desejado ou ele não estava disponivel!");

                pegaOpcao();
            }
        }
        /// <summary>
        /// método para atualizar o veiculo no arrey
        /// </summary>
        /// <param name="modelo">Modelo digitado pelo usuario</param>
        /// <returns>Retorna se possivel realizar a locação, true para sim e false para não</returns>
        private static bool atualizarVeiculo(string modelo, string situacao)
        {


            for (int i = 0; i < carros.GetLength(0); i++)
            {
                if (modelo.Equals(carros[i, 0]) && carros[i, 2] == "Sim" && situacao == "alocar")
                {
                    carros[i, 2] = "Não";
                    return true;
                }
                else if (modelo.Equals(carros[i, 0]) /*&& carros[i, 2] == "Não"*/ && situacao == "desalocar")
                {
                    carros[i, 2] = "Sim";
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// método apenas para vizualizar os veiculos
        /// </summary>
        private static void vizualizarVeiculos()
        {
            Console.Clear();
            mostrarBemVindo();
            for (int i = 0; i < carros.GetLength(0); i++)
            {
                Console.WriteLine($"Modelo: {carros[i, 0]} Ano: {carros[i, 1]} Disponivel?: {carros[i, 2]}");
            }

        }
        /// <summary>
        /// Metodo de carregar os veiculos no array
        /// </summary>
        private static void carregarVeiculos()
        {
            carros = new string[2, 3]
            {
                {"Celta","2018", "Sim"},
                {"Vectra","2015","Não"}
            };

        }
        /// <summary>
        /// Metodo para mostrar o menu de locação 
        /// </summary>
        /// <returns></returns>
        private static int mostrarMenuLocacao()
        {
            Console.WriteLine("Selecione a opção desejada ou pressione qualquer outro botão para sair: " +
                              "\n(1) - visualizar veiculos" +
                              "\n(2) - Alocar veiculo" +
                              "\n(3) - Desalocar um veiculo");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;

        }
        /// <summary>
        /// Metodo para mostrar o menu bem vindo
        /// </summary>
        private static void mostrarBemVindo()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("============ Bem vindo a locadora AMBEV ============");
            Console.WriteLine("====================================================");
        }

        private static string ModeloVeiculoSolicitado(string situacao)
        {
            Console.Clear();
            mostrarBemVindo();
            Console.WriteLine($"Digite o modelo do veiculo que desejas {situacao}: ");
            return Console.ReadLine();
        }
    }
}