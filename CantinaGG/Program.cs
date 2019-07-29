using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CantinaGG.Classes;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            ClasseCantina cantina = new ClasseCantina();

           Console.WriteLine("----------Menu----------");
           Console.WriteLine("-----Cantina GG---------");
           Console.WriteLine("------------------------");
           Console.WriteLine("-- 1 --Pastel R$ 4,00---");
           Console.WriteLine("-- 2 ---Refri R$5,00----");
           
       
           cantina.CompraLanche();
           
        }
    }
}
