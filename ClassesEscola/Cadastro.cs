using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEscola
{
    public class Cadastro
    {

        string[,] arrayAluno = new string[5,5];
        Boletim boletim = new Boletim();
        public void inserir()
        {
            Console.Clear();
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
           // for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Console.WriteLine("Informe o nome do  Aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 0] = i.ToString();
                arrayAluno[i, 1] = nome;

                
                //media
                arrayAluno[i, 2] =digitaNotas().ToString();



                //informações e frequencia
                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalAulas);

                Console.WriteLine("Informe o numero de faltas");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);

                var frequencia = boletim.frequencia(totalAulas, numeroFaltas);
                arrayAluno[i, 3] = frequencia.ToString();
                //informa situação                
                arrayAluno[i, 4] = boletim.RetornaSituacao(media:0, frequencia);




            }
        }

        public int digitaNotas()
        {
            Console.Clear();
            Console.WriteLine("Informe a Nota");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe a Nota");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Informe a Nota");
            int.TryParse(Console.ReadLine(), out int nota3);

            //calculando a media
           return boletim.medias(nota1, nota2, nota3);
        }

        public void Listar()
        {
            //for (int i = 0; i < arrayAluno.GetLength(0); i++)
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {

                Console.WriteLine($"Id.........: {arrayAluno[i, 0]}");
                Console.WriteLine($"Nome.......: {arrayAluno[i, 1]}");
                Console.WriteLine($"Média......: {arrayAluno[i, 2]}");
                Console.WriteLine($"Frequencia.: {arrayAluno[i, 3]}%");
                Console.WriteLine($"Situação...: {arrayAluno[i, 4]}");
                
            }
        }


        public string ApresentaMenuInicial()
        {
            //Entrou no menu inicial inicializa a limpeza da tela
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inseir um novo registro.");
            Console.WriteLine("2 - Excluir um registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Alterar informações.");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");
            
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();


        }



        public void Excluir(int pId)

        {
            Console.Clear();
            Console.WriteLine("Informe registro que deseja excluir");
            int.TryParse(Console.ReadLine(), out int reg);


            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i,0] == pId.ToString())
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";
                    break;
                }
            }
        }


        public void Alterar(int pId)
        {
            Console.Clear();
            Console.WriteLine("Informe registro que deseja excluir");
            int.TryParse(Console.ReadLine(), out int reg);
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
                {
                    if (arrayAluno[i, 0] == pId.ToString())
                    {
                    var media = digitaNotas();
                    arrayAluno[i, 2] = media.ToString();//media
                    var frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = boletim.RetornaSituacao(media,frequencia);//situação
                    break;
                    }

                }

        }



    }
}