using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczby
{
    interface ICalculator
    {
        /// <summary>
        /// To jest metoda do liczenia sumy liczb parzystych
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int SumEvenNumbers(int number);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int SumOddNumbers(int number);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int MultiEvenNumbers(int number);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int MultiOddNumbers(int number);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int DivOddNumbers(int number);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        int DivEvenNumbers(int number);

    }
}
