using System;

namespace Задание_01
{
    //1.Разработать структуру для решения линейного уравнения 0=kx+b.
    //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
    //Для решения уравнения предусмотреть метод Root.
    //Создать экземпляр разработанной структуры.
    //Осуществить использование экземпляра в программе.
    class Program
    {
        static void Main(string[] args)
        {
            decimal K, B;
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("Вас приветсвует КАЛЬКУЛЯТОР линейных уравнений тип 0 = kx + b !");
            Console.WriteLine();

        ReadK:
            Console.WriteLine("Введите значение коэффициента k: ");
            try { K = Convert.ToDecimal(Console.ReadLine());
                //Данную проверку не удалось реализовать в структуре !!!
                if (K == 0) {Console.WriteLine("Значение k не может равняться нулю!!"); K = 1; } } 
            catch { Console.WriteLine("Введено некорректное значение!"); goto ReadK; }

        ReadB:
            Console.WriteLine("Введите значение свободного члена b ");
            try { B = Convert.ToDecimal(Console.ReadLine()); }
            catch { Console.WriteLine("Введено некорректное значение!"); goto ReadB; }

            linearEquation LE = new linearEquation(K, B);
            Console.WriteLine();
            LE.Root();
            Console.WriteLine();
            Console.WriteLine("До свидания !");
            Console.ReadKey();
        }
    }
    //Создаваемая структура    
    public struct linearEquation
    {
        public linearEquation(decimal k_, decimal b_)
        {
            K = k_;
            B = b_;
            k = K;
            b = B;
        }

        private decimal k;
        private decimal b;
        public decimal K { set; get; }
        //После активизации данной проверки, K = k_ в конструкторе подчёркивается красным, вынес данную проверку в основную программу
        /*{set
            {
                if (value != 0) { k = value; }
                else {Console.WriteLine("Значение k не может равняться нулю!!"); k = 1; }
            }
            get { return k; }}*/
        public decimal B { set; get; }
               
        public void Root()
        {
            decimal x = (-1 * b) / k;
            Console.WriteLine("Для уровнения 0 =  {0:F2}*x + {1:F2}", k, b);
            Console.WriteLine("x = {0:F2}", x);
        }
    }
}
