using System;
using System.Data;

namespace TestLibrary
{
    public static class AreaCalculatin
    { 
        /// <summary>
        /// Высчитывает площадь круга по радиусу 
        /// </summary>
        /// <param name="r">Значение радиуса круга</param>
        /// <returns>Возвращает значение площади круга</returns>
        /// <returns>Если радиус равен отрицательному числу, то будет возвращен 0</returns>
        public static double CircleArea(int r)
        {
            //Возвращает 0 если радиус отрицательный
            if (r < 0)
            {
                return 0;
            }
            //S = π × r2
            return Math.Round(Math.PI * Math.Pow(r, 2), 2);
        }

        /// <summary>
        /// Высчитывает площать треугольника по формуле Герона
        /// </summary>
        /// <param name="a">Значение стороны A</param>
        /// <param name="b">Значение стороны B</param>
        /// <param name="c">Значение стороны C</param>
        /// <returns>Возвращает значение площади треугольника</returns>
        /// <returns>Если треугольник неправильный, то будет возвращен 0</returns>
        public static double TriangleArea(int a, int b, int c)
        {
            //Проверка треугольника на правильность 
            if ( (a + b) < c | (a + c) < b | (c + b) < a )
            {
                return 0;
            }

            //Расчет полуперметра
            //1/2(a+b+c)
            double p = 0.5 * (a + b + c);
           

            //S = √p(p-a)(p-b)(p-c)
            return Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)), 2);
        }

       

    }
}
