// Написать программу вычисления функции Аккермана
int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int temp = AckermannFunction(m, n);
AckermannFunction(m,n);
Console.WriteLine($"Функция Аккермана {temp}");
