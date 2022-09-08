// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32 (Console.ReadLine());


int SummNumber(int n, int m)
{
    if (n == 0)
        return 0;
    else
    return n + SummNumber(n - 1, m ) ;
}

Console.WriteLine($"Сумма элементов -> {SummNumber(n, m)}");

