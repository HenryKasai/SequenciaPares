using System;

namespace SequenciaPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int número, zero;
            zero = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira um número inteiro positivo: ");
            bool númerobool = Int32.TryParse(Console.ReadLine(), out número);
        
            if (!númerobool || número < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Números pares entre 0 e {número}: ");
                while (zero < número )
                {
                    Console.Write($"{zero} ");
                    zero = zero + 2;

                }
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
