// Найти сумму цифр числа
int SplitNumber(int number)
{
    if(number == 0) return 0;
    else return number % 10 + SplitNumber(number / 10);
}
int element = int.Parse(Console.ReadLine()??"0");
Console.WriteLine(SplitNumber(element));
