using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesEscola;

namespace GestorEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            var escolhaInicial = cadastro.ApresentaMenuInicial();
          

            while (true)
            {
                //Iniciando a escolha do nosso menu
                switch (escolhaInicial)
                {
                    //1- Insere as informações 
                    case "1": { cadastro.inserir(); } break;
                    //2- Remove informações da nossa lista
                    case "2":// { cadastro.Excluir(); } break;
                    //Lista as informações da lista
                    case "3": { cadastro.Listar(); } break;

                    case "4":// { cadastro.Alterar(); } break;

                    //Sai do nosso sistema
                    case "5":
                        {
                            //Return dentro do nosso caso de escolha ele sai do nosso meto principal ou 
                            //metodo que estamos dentro de contexto
                            return;
                        }
                }
                //Alimento a escolha novamente 
                escolhaInicial = (cadastro.ApresentaMenuInicial());
            }
            

       

        }
    }
}
    

