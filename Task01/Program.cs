// Показать натуральные числа от N до 1, N задано
void PrintElement(int n)
{
    if (1 <= n)
    {
        Console.WriteLine("{0}", n);
        PrintElement(n - 1);
    }
}
int n = int.Parse(Console.ReadLine() ?? "0");
PrintElement(n);
