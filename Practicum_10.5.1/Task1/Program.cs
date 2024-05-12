using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new Calculator();

            while (true)
            {
                try
                {
                    Console.WriteLine("Вас приветствует мини-калькулятор, который будет для вас подсчитывать сумму двух чисел! \nДавайте начнём складывать! ");
                    Console.WriteLine("Введите первое число: ");
                    float x = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    float y = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("{0} + {1} = {2}", x, y, calculator.Add(x, y));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Давайте ещё!\n");
                }
            }
        }
    }
}