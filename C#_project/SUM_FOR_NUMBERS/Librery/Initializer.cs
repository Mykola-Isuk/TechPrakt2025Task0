using System;

namespace Library
{
    public class Initializer
    {
        public int Num1 { get; private set; }
        public int Num2 { get; private set; }

        public void InitializeNumbers()
        {
            Console.Write("Введіть перше число: ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            Num2 = int.Parse(Console.ReadLine());
        }
    }
}
