// Найти сумму элементов от M до N, N и M заданы
void FindeSum(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        Console.WriteLine($"Сумма элементов {sum}");
        return;
    }
    FindeSum(m, n - 1, sum);
}
Console.WriteLine($"Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("");
int temp = m;
if (m > n)
{
    m = n;
    n = temp;
}
FindeSum(m, n, temp = 0);
