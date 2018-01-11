using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    /// <summary>
    /// Classe que soma dois números double
    /// </summary>
    class Somar
    {
        /// <summary>
        /// Método para somar
        /// </summary>
        /// <param name="numeroUm">Primeiro número para somar</param>
        /// <param name="numeroDois">Segundo número para somar</param>
        /// <returns>Retorna os dois parâmetros como double</returns>
        public double Soma(double numeroUm, double numeroDois)
        {
            return numeroUm + numeroDois;
        }
    }
}
