using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
   public class Conta
    {
        double saldo = 0;
        public double Saldo { get { return saldo; } }
        /// <summary>
        /// Construtor!!!
        /// </summary>
        public Conta()
        {
            
            saldo = 1000;
        }
     /// <summary>
     /// metodo para sacar de acordo com o saldo disponivek
     /// </summary>
     /// <param name="valor">Valor para sacar</param>
     /// <returns>Retorna se o saque foi feito ou não </returns>
        public bool Sacar(double valor)
        {

            if (valor<= saldo)
            {// desconta do valor em saldo na conta
                saldo -= valor;
                return true;
            }
         return false;
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
