using System;
using System.Linq;

namespace Test1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            char symbol = '#';
            string str = "I dont like# automn.";
            string[] newStr = str.Split(' ');
            
            var result = newStr.SingleOrDefault(s => s.EndsWith(symbol));

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
