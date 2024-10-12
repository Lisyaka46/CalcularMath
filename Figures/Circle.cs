using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSquare.Figures
{
    /// <summary>
    /// Управление фигурой круга
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Вычисление площади круга
        /// <code>
        /// PI * Radius ^ 2
        /// </code>
        /// </summary>
        /// <param name="Radius">Радиус данного круга</param>
        /// <exception cref="ArgumentException">Исключение при отрицательном значении радиуса</exception>
        /// <returns>Вычисленная площадь</returns>
        public static double SquareCalculate(double Radius)
        {
            if (Radius < 0d) throw new ArgumentException($"Радиус круга не может быть отрицательным! ({nameof(Radius)}={Radius})");
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
