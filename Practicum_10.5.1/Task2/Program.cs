namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            ICalculator calculator = new Calculator(logger);

            while (true)
            {
                try
                {
                    Console.WriteLine("Вас приветствует мини-калькулятор, который будет для вас подсчитывать сумму двух чисел! \nДавайте начнём складывать! ");
                    Console.WriteLine("Введите первое число:");
                    float x = float.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    float y = float.Parse(Console.ReadLine());

                    float sum = calculator.Add(x, y);
                    Console.WriteLine($"{x} + {y} = {sum}");
                }
                catch (FormatException)
                {
                    logger.Error("Ошибка ввода! Пожалуйста, введите корректное число!");
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