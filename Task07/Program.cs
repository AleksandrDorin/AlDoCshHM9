// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
void FindeSum(int m, int n, int sum, int count)
{
    sum = m + n;
    if (count >= 5)
    {

        return;
    }
    Console.WriteLine($"{sum}");
    count++;
    m = n;
    n = sum;
    FindeSum(m, n, sum, count);
}
Console.WriteLine($"Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("");
FindeSum(m, n, 0, 0);
