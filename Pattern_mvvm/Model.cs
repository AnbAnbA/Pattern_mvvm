using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_mvvm
{
    static class Model
    {
        /// <summary>
        /// data
        /// </summary>
        public static List<string> dataList = new List<string> { "Сложение", "Вычитание", "Умножение", "Деление" };
        public static double a;
        public static double b;
        public static double res;
        public static string error;
    }
}
