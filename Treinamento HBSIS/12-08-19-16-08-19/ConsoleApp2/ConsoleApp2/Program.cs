using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //          String[] listaDeNomes = new string[2];
            //           String[] listaDeIdade = new string[2];
            //           for (int i = 0; i < listaDeNomes.Length; i++)
            //           {
            //               Console.WriteLine("Coloque seu nome");
            //               listaDeNomes[i] = Console.ReadLine();
            //               Console.WriteLine("Coloque sua Idade");
            //               listaDeIdade[i] = Console.ReadLine();
            //               Console.Clear();
            //           }
            //           for (int i = 0; i < listaDeNomes.Length; i++)
            //           {
            //               Console.WriteLine($"Nome Cadastrado: {listaDeNomes[i]} e Idade: {listaDeIdade[i]}");
            //           
            //           }
            #endregion

            string[] StringListInfo = new string[2];
            for (int i = 0; i < StringListInfo.Length; i++)
            {
                Console.WriteLine("Coloque seu nome, idade e peso");
                StringListInfo[i] =
                    $"Nome: {IsValid("", "Nome")} " +
                    $"Idade: {IsNumberFormat(IsValid("", "Idade"),"00")}" +
                    $" Peso: {IsNumberFormat(IsValid("", " Peso"), "N2")} kg";
           Console.Clear();
            }
            for (int i = 0; i < StringListInfo.Length; i++)
                Console.WriteLine(StringListInfo[i]);

            Console.ReadKey();
        }


        public static string IsValid (string value,string fieldName)
        {
            var retorno = value;

            while (string.IsNullOrEmpty(retorno)||string.IsNullOrWhiteSpace(retorno))
            {
                Console.Clear();
                Console.WriteLine($"Informe um valor para o campo{fieldName}:");
                retorno = Console.ReadLine();
            }
            return retorno;
        }

        private static string IsNumberFormat (object values, string format)
        {
            int.TryParse(values.ToString(), out int retorno);
            return retorno.ToString(format);
        }
    }
}
