using System;
using System.Linq;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 0, -1, 6, 4, -1, -3};
            var count = numbers.Where(n => n > 0).Count();
            var average = numbers.Where(n => n > 0).Average();
            Console.WriteLine($"Количество положительных элементов: {count}, а их среднее значение: {average}");
        }
    }
}
