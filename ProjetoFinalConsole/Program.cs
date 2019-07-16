using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 6];

            int IndiceBaseDeDados = 0;
            var escolhaMenu = ChamarMenuInicial();

            while (true)
            {
                switch (escolhaMenu)
                {
                    //1- Insere as informações 
                    case "1": { InseriValoresNaLista(ref baseDeDados, ref IndiceBaseDeDados); } break;
                    case "2": { RemoverInformacoes(ref baseDeDados); } break;
                    case "3": { MostrarInformacoes(baseDeDados); } break;
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break;
                    case "5": { } break;
                    case "6": { } break;
                    case "7":
                        {
                            return;
                        }
                }
                escolhaMenu = ChamarMenuInicial();
            }

        }
        /// <summary>
        /// Chama o menu inicial
        /// </summary>
        public static string ChamarMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1-Inserir um Livro");
            Console.WriteLine("2-Remover um Livro");
            Console.WriteLine("3-Listar Livros");
            Console.WriteLine("4-Listar Livros Inativos");
            Console.WriteLine("5-Alocar um Livro");
            Console.WriteLine("6-Desalocar um Livro");
            Console.WriteLine("7-Sair");

            Console.WriteLine("Digite o número da opção desejada:");
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }

        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int indiceBase)
        {


            Console.WriteLine("---------Inserindo valores na lista---------");

            Console.WriteLine("Informe o Nome do Livro:");
            //Pegamos a informação digitada pelo usuario, aqui neste elemento esperamos o nome do livro
            var nomeDoLivro = Console.ReadLine();

            Console.WriteLine("Informe o Autor do Livro");
            var AutorDoLivro = Console.ReadLine();

            Console.WriteLine("Informe se e Livro esta Disponivel Sim ou Não");
            var StatusDisponivel = Console.ReadLine();

            //Aumenta o tamanho da nossa lista quando chegou no limite.
            AumentaTamanhoLista(ref baseDeDados);

            //Iniciamos o laço de repetição para varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira unica nosso registro "(" e ")" garante que ele incremente primeiro 
                //antes de fazer a conversão para string
                baseDeDados[i, 0] = (indiceBase++).ToString();
                //Carregamos na segunda coluna o valor do nome
                baseDeDados[i, 1] = nomeDoLivro;
                //carregamos na terceira coluna o valor autor
                baseDeDados[i, 2] = AutorDoLivro;
                //Carrega a coluna que indentifica se o registro está ativo
                baseDeDados[i, 3] = "true";
                //Identificamos agora a data e hora de criação dos registros dentro do sistema
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //Finalizamos aqui para apenas inseir um registro por vez
                baseDeDados[i, 5] = StatusDisponivel;

                break;
            }
            //Informamos para o usuario que finalizou o registro e agora o mesmo irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();


        }


        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponivel
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "limiteDaLista" para false
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = baseDeDados;
                //Aqui Limpamos nossa lista antigas e assinamos novamente com uma lista com mais espaços
                baseDeDados = new string[baseDeDados.GetLength(0) + 1, 5];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador unico
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    //A informação da idade foi atualizada
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    //Identificador se o registro esta ativo
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    //Data da alteração deste registro
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }


        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistroNAtivos = "false")
        {
            //informamos em que tela o mesmo esta
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
            //Comparação que identifica visualmente quais registros estamos mostrando
            if (mostrarRegistroNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema.");
            //Laço simples aonde o mesmo mostra de maneira formatada as informações 
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Aqui deixamos de mostrar as informações que foram desabilitadas dentro do sistema.
                if (baseDeDados[i, 3] != mostrarRegistroNAtivos)
                    Console.WriteLine($"ID {baseDeDados[i, 0]} " +
                          $"- Nome:{baseDeDados[i, 1]} " +
                          $"- Idade:{baseDeDados[i, 2]}" +
                          $"- Data Alteração:{baseDeDados[i, 4]}" +
                          $"- Disponivel:{baseDeDados[i, 5]}");

            }

            //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas em
            //nosso metodo.
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }


        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            //Identificamos a tela do menu que o usuario está
            Console.WriteLine("Area de remoção de registro do sistema.");
            //Laço de repetição que mostra as informações dentro da tela de exclusão para facilitar a 
            //escolha do id corretamente
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Identifica que so deve remover os valores ativos dentro do sistema
                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"ID:{baseDeDados[i, 0]} " +
                          $"- Nome:{baseDeDados[i, 1]} " +
                          $"- Idade:{baseDeDados[i, 2]}");
            }
            //Indicamos para usuario informar um id dentro do nosso sistema para remover
            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();
            //outro laço agora para remover o registro caso o mesmo exista
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {   //Aqui comparamos os registro para validar o id
                //Colocamos um "&&" pois a comparação de um valor string com um valor null 
                //pode gerar erro.
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {  //Agora trocamos este valor para um identificador string "false"
                    baseDeDados[i, 3] = "false";
                    //Aqui indicamos a data que foi alterado esse registro.
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            //Finalizamos as operações desta tela
            Console.WriteLine("Operações finalizadas.");
            Console.WriteLine("Para retornar ao menu inicial apertar qualquer tecla.");
            Console.ReadKey();
        }

        public static void PesquisaLivro(ref string[,] baseDeDados)
        {

            Console.WriteLine("--------- Pesquisando o livro na lista---------");

            Console.WriteLine("Informe o Nome do Livro:");
         
            var nomeDoLivro = Console.ReadLine();

            
                if (nomeDoLivro.ToLower().Replace(" ", "") == nomeDoLivro.ToLower().Replace(" ", ""))
                    

                
            



            //Informamos para o usuario que finalizou o registro e agora o mesmo irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();


        }      
    }
}
