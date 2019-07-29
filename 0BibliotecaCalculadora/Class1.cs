using System;

namespace BibliotecaCalculadora
{
    public class Class1
    {

        public int Adicao(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtracao(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicacao(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Divisao(int n1, int n2)
        {
            return n1 / n2;
        }


        public double AreaRetangulo(int Base, int Altura)
        {

            return  Base * Altura;
        }

        public double AreaTrianguloEsquilatero(int Base, int Altura)
        {

            return ((Base * Altura) / 2);
        }


        public double RaioDoCirculo(double area)
        {

            return (area / 3.14);
        }



    }
}
