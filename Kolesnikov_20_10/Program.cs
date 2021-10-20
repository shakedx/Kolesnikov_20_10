using System;

namespace Kolesnikov_20_10
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Введите 1,2 или 3");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double a = 0, b = 0, z, y;
                switch (n)
                {
                    case 1: a = 0.3; b = 0.9; break;
                    case 2: a = 4.3; b = 3.15; break;
                    case 3: a = 6.5; b = 3.5; break;
                }
                z = Math.Sin(Math.Pow(x,2));
                if (x < a) y = a + b * x + Math.Sin(Math.Pow(x, 2)) * z * Math.Pow(x, 3.5);
                else if (a <= x && x < Math.Pow(b, 2)) y = a + (Math.Log(10) * Math.Abs(a * b - z * Math.Pow(x, 3))) + Math.Log(10, x);
                else y = Math.Sqrt(Math.Abs(a+Math.Atan(z*x)));
                Console.WriteLine($"y={y:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
