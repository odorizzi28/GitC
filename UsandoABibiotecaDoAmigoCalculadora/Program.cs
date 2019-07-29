using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraBiblioteca;

namespace UsandoABibiotecaDoAmigoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Operacoes teste = new Operacoes();
            Console.WriteLine($"Soma: {teste.Adicao(5, 5)}");
            Console.WriteLine($"Subtracao: {teste.Subtracao(5, 5)}");
            Console.WriteLine($"Multiplicacao: {teste.Multiplicacao(5, 5)}");
            Console.WriteLine($"Divisao: {teste.Divisao(5, 5)}");
            Console.WriteLine($"Triangulo Equilatero: {teste.TrianguloEquilatero(5, 5)}");
            Console.WriteLine($"Area Retangulo: {teste.AreaRetangulo(5, 5)}");
            Console.WriteLine($"Raio Circulo: {teste.RaioCirculo(50)}");
            Console.ReadKey();
        }
    }
}
