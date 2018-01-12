using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    class Calculadora
    {
        /// <summary>
        /// Parâmetro 1 + parâmetro 2
        /// </summary>
        /// <param name="numeroUm">Primeiro número</param>
        /// <param name="numeroDois">Segundo número</param>
        /// <returns></returns>
        public double Somar(double numeroUm, double numeroDois)
        {
            return numeroUm + numeroDois;
        }

        /// <summary>
        /// Parâmetro 1 - parâmetro 2
        /// </summary>
        /// <param name="numeroUm">Primeiro número</param>
        /// <param name="numeroDois">Segundo número</param>
        /// <returns></returns>
        public double Subtrair(double numeroUm, double numeroDois)
        {
            return numeroUm - numeroDois;
        }

        /// <summary>
        /// Parâmetro 1 * parâmetro 2.
        /// </summary>
        /// <param name="numeroUm">The numero um.</param>
        /// <param name="numeroDois">The numero dois.</param>
        /// <returns></returns>
        public double Multiplicar(double numeroUm, double numeroDois)
        {
            return numeroUm * numeroDois;
        }

        /// <summary>
        /// Parâmetro 1 / parâmetro 2
        /// </summary>
        /// <param name="numeroUm">The numero um.</param>
        /// <param name="numeroDois">The numero dois.</param>
        /// <returns></returns>
        public double Dividir(double numeroUm, double numeroDois)
        {
            return numeroUm / numeroDois;
        }
    }
}
