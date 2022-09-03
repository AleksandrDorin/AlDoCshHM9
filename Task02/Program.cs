// Показать натуральные числа от M до N, N и M заданы
void PrintElement(int n, int m)
{
    if (n < m)
    {
        Console.WriteLine("{0}", n);
        PrintElement(n + 1, m);
    }
    else if (n > m)
    {
        Console.WriteLine("{0}", n);
        PrintElement(n - 1, m);
    }
    else if(n == m)
    {
        Console.WriteLine("{0}", n);
    }
}
Console.WriteLine($"Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0"); //10
Console.WriteLine($"Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0"); //20
Console.WriteLine($"Ряд числе от M({m}) , до N({n}) ");
PrintElement(m, n);