using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    class Media
    {

        public Media(double nota1,double nota2,double nota3)
        {

            ChamaMedia(nota1,nota2,nota3);

        }

        public double ChamaMedia(double nota1, double nota2, double nota3)
        {
          
            double media = (nota1 + nota2 + nota3) / 3;

            return media;
        }


        public int Frequencia(int TotalDias,int TotalFaltas)
        {

         return (TotalDias*100)/TotalFaltas ;
        }

        public void situacao(int media, int frequencia)
        {
            if ((media >=7) && (frequencia>=75))
            {
                Console.WriteLine($"Aluno Aprovado com media: {media} e frequencia de {frequencia}%");
            }
            else
            {
                Console.WriteLine($"Aluno Reprovado com media: {media} e frequencia de {frequencia}%");
            }
        }

    }
}
