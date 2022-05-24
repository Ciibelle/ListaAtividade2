using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            double euro = 5.13;
            double real = 0;
            double qt = 750;

            real = (qt * euro);
            Console.WriteLine($"O valor em real é: {real}");
        }
    }
}
