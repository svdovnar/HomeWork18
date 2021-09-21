using System;
using System.Linq;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Женя скоро будет свободен, а у вас всё только начинается.";
            var result = message.Where(m => m != 'о').ToArray();
            Console.WriteLine(result);
        }
    }
}
