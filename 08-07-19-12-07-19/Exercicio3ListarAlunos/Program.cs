using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3ListarAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDePessoas = new string[20, 3]

                {
                {"Edilson   ","24","Masc"},
                {"Jota      ","22","Masc"},
                {"Aline     ","20","Fem"},
                {"Junior    ","22","Masc"},
                {"Francis   ","28","Masc"},
                {"Stive     ","26","Masc"},
                {"Will      ","22","Masc"},
                {"Eduardo   ","22","Masc"},
                {"Jubileu   ","22","Masc"},
                {"Edson     ","22","Masc"},
                {"Abelardo  ","26","Masc"},
                {"Julia     ","22","Fem"},
                {"Julio     ","23","Masc"},
                {"Anita     ","20","Fem"},
                {"Beatriz   ","21","Fem"},
                {"Brenda    ","22","Fem"},
                {"Salvador  ","44","Masc"},
                {"Jhony     ","42","Masc"},
                {"Osmar     ","54","Masc"},
                {"Wilson    ","56","Masc"},
                };
             

            for (int i = 0; i < listaDePessoas.GetLength(0); i++)
            {
                var Nome = listaDePessoas[i, 0];
                var Idade= listaDePessoas[i, 1];
                var Sexo = listaDePessoas[i, 2];

                Console.WriteLine($"Nome: {Nome}  Idade:  {Idade} Sexo:  {Sexo}");
            }
            Console.ReadKey();
        }
    }
}
