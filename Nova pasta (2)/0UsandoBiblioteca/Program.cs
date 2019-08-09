using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadora;

namespace UsandoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var Classe = new Class1();
       
            Console.WriteLine("digite o primeiro numero");
            int.TryParse(Console.ReadLine(), out int n1);
            Console.WriteLine("digite o Segundo numero");
           int.TryParse(Console.ReadLine(), out int n2);
           Classe.Adicao(n1, n2);



        }
    }
}
