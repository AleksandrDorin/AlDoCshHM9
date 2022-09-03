// Написать программу возведения числа А в целую стень B
double Degree(double a, double b)
{
    if (b > 1) return a * Degree(a, b - 1);
    return a;
}

Console.WriteLine("Введите А");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите В");
double b = Convert.ToDouble(Console.ReadLine());

double result = Degree(a, b);
Console.WriteLine($"\n {result}");
