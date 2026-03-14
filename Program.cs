using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стороны прямоугольника");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double p = Math.Round((a + b) * 2, 2); double s = Math.Round(a*b, 2);
        Console.WriteLine("Периметр прямоугольника {0:f2}; Площадь прямоугольника {1:f2}", p, s);
        Console.ReadKey();
    }
}
