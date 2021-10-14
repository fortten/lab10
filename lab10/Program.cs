using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        // Угол задани целыми значениями gradus, min, sec. Реализовать класс, в котором эти значения в виде свойств, для которых предусмотреть проверку
        // корректности данных. Класс должен содержать конструктор для установки начальных значений и метод ToRadians для перевода угла в радианы.
        // Создать объект на основе класса, осуществить использование объекта в программе.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение градусов:");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд:");
            int s = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(g, m, s);
            angle.Result();
            angle.ToRadians();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    class Angle
    {
        private int grad;
        private int min;
        private int sec;
        #region Свойства
        public int Grad
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    grad = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение");
                }
            }
            get
            {
                return grad;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение");
                }
            }
            get
            {
                return sec;
            }
        }
        #endregion
        public Angle(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public void Result()
        {
            Console.WriteLine("Заданный угол = {0}° {1}' {2}\"", Grad, Min, Sec);
        }        
        public void ToRadians()
        {
            double radian = ((Grad * Math.PI) / 180) + ((Min * Math.PI) / (180 * 60) + ((Sec * Math.PI) / (180 * 3600)));
            Console.WriteLine("Угол в радианах = {0}", radian);
        }        
    }
}
