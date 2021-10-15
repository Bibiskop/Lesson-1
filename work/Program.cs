using System;
class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }
    static void Task1()
    {
        double x;
        double y;

        Console.Write("Введите первое число: ");
        string str = Console.ReadLine();
        x = Convert.ToDouble(str);

        Console.Write("Введите второе число:");
        y = Convert.ToDouble(Console.ReadLine());
        double z = x + y;

        Console.WriteLine(x + "+" + y + "=" + z);
        Console.ReadLine();
    }
    static void Task2()
    
    {
        double a = 1;
        double b = 1;
        double c = 1;
        double x;
        Console.Write("Введите значение x: ");
        string s = Console.ReadLine();
        x = Convert.ToDouble(s);
        double f = a * Math.Pow(x, 2) + b * x + c;
        Console.WriteLine("{0} * x^2 + {1} * x {2}, при x = {3}, d = {4}", a, b, c, x, f);
        Console.ReadLine();
    }
    static void Task3()
    
    {
        int a = 10;
        int b = 20;
        int t = a;
        a = b;
        b = t;
    }
    static bool Odd(int n)
    {
        return n % 2 == 0;
    }
    static void Task4()
    {
        int value = 100500;
        Console.WriteLine(Odd(value));
    }
    static void Print(string msg, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(msg);
    }
    static void Print(string msg, ConsoleColor foregroundcolor)
    {
        Console.ForegroundColor = foregroundcolor;
        Console.WriteLine(msg);
    }
    static void Task5()
    {
        Print("Привет!\n", 10, 10);
        Print("Привет еще раз!", ConsoleColor.Red);
        Console.ReadLine();
    }
    static bool IsTriangle (double a, double b, double c)
    {
        return a + b > c && a + c > b && c + b > a;
    }
    static double S(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    static void Task6()
    {
        Console.Write("Введите а:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите c:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Может существовать треугольник с такими сторонами:" + IsTriangle(a, b, c));
        Console.ReadLine();
    }
}