using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows;

namespace MinhaPrimeiraBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new GetFiles();

            var arquivos = teste.RetornaArquivosDoMeuDocumentos();
            for (int i = 0; i < arquivos.Length; i++)
            {
                Console.WriteLine(arquivos[i]);
            }

            var imagem = teste.RetornaArquivosImagesFiles();
            for (int i = 0; i < imagem.Length; i++)
            {
                Console.WriteLine(imagem[i]);
            }




            var git = teste.RetornaArquivosGit();
             for (int i = 0; i < arquivos.Length; i++)
             {
                 Console.WriteLine(git[i]);
             }


             
            Console.ReadKey();
        }
    }
}
