using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSquare.Figures
{
    /// <summary>
    /// Управление фигурой треугольника
    /// </summary>
    public class Triangle
    {
        /// <summary>
        /// Вычислить площадь треугольника по трём сторонам
        /// <code>
        /// √(р * (р — Foot) * (р — СatheterLeft) * (p — СatheterRight))
        /// </code>
        /// </summary>
        /// <param name="Hypotenuse">Гипотенуза треугольника</param>
        /// <param name="СatheterLeft">Левый катет треугольника</param>
        /// <param name="СatheterRight">Правый катет треугольника</param>
        /// <returns>Вычисленная площадь треугольника</returns>
        /// <exception cref="ArgumentException">Исключение при отричательной длинне одной из сторон треугольника</exception>
        /// <exception cref="Exception">Исключение при несуществующем треугольнике</exception>
        public static double SquareCalculate(double Hypotenuse, double СatheterLeft, double СatheterRight)
        {
            if (Hypotenuse < 0d || СatheterLeft < 0d || СatheterRight < 0d) throw new ArgumentException("Значения сторон треугольника не могут быть отрицательными! " +
                $"({nameof(Hypotenuse)}={Hypotenuse}, {nameof(СatheterLeft)}={СatheterLeft}, {nameof(СatheterRight)}={СatheterRight})");

            double HalfMeter = (Hypotenuse + СatheterLeft + СatheterRight) / 2d; // полупериметр

            if (HalfMeter < Hypotenuse || HalfMeter < СatheterLeft || HalfMeter < СatheterRight)
                throw new Exception("Такого треугольника не существует! " +
                $"({nameof(Hypotenuse)}={Hypotenuse}, {nameof(СatheterLeft)}={СatheterLeft}, {nameof(СatheterRight)}={СatheterRight})");
            return Math.Sqrt(HalfMeter * (HalfMeter - Hypotenuse) * (HalfMeter - СatheterLeft) * (HalfMeter - СatheterRight));
        }

        /// <summary>
        /// Узнать соответствует ли данный треугольник прямоугольному типу
        /// <code>
        /// Foot ^ 2 == СatheterLeft ^ 2 + СatheterRight ^ 2
        /// </code>
        /// </summary>
        /// <param name="Hypotenuse">Гипотенуза треугольника</param>
        /// <param name="СatheterLeft">Левый катет треугольника</param>
        /// <param name="СatheterRight">Правый катет треугольника</param>
        /// <returns>Соответствие треугольника с прямоугольным</returns>
        /// <exception cref="ArgumentException">Исключение при отричательной длинне одной из сторон треугольника</exception>
        public static bool CheckRectangularTriangle(double Hypotenuse, double СatheterLeft, double СatheterRight)
        {
            if (Hypotenuse < 0d || СatheterLeft < 0d || СatheterRight < 0d) throw new ArgumentException("Значения сторон треугольника не могут быть отрицательными! " +
                $"({nameof(Hypotenuse)}={Hypotenuse}, {nameof(СatheterLeft)}={СatheterLeft}, {nameof(СatheterRight)}={СatheterRight})");
            return Math.Pow(Hypotenuse, 2) == Math.Pow(СatheterLeft, 2) + Math.Pow(СatheterRight, 2);
        }
    }
}
