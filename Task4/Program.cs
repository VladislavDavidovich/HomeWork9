// Написать программу вычисления функции Аккермана

Console.WriteLine("Введите первое число ");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите первое число ");
int m = Convert.ToInt32 (Console.ReadLine());

int Akk(int n, int m)
{ 
    if (n == 0) 
    return m + 1;

    if (n != 0 && m == 0) 
    return Akk(n - 1, 1);

    if (n > 0 && m > 0) 
    return Akk(n - 1, Akk(n, m - 1));
    return Akk(n,m);
}
Console.WriteLine(Akk(n,m));
