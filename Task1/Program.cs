// // Показать натуральные числа от N до 1, N задано
Console.WriteLine("Введите число ");
int n = Convert.ToInt32 (Console.ReadLine());
int m = 1;

int NumberArray(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NumberArray(n, m + 1)}, ");
    return m;
}

Console.WriteLine(NumberArray(n, m));
