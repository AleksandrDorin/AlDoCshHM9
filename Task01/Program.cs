// Показать натуральные числа от N до 1, N задано
void PrintElement(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine("{0}", n);
        PrintElement(m, n - 1);
    }
}

int n = int.Parse(Console.ReadLine() ?? "0");
int m = 1;
PrintElement(m, n);
