// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32 (Console.ReadLine());


int NumberArray(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NumberArray(n, m + 1)}, ");
    return m;
}

// Console.WriteLine(NumberArray(n, m));
