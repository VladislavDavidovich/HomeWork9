// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

Console.WriteLine("Введите первое число ");
int FirstNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите первое число ");
int SecondNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите сколько надо показать чисел ");
int QuantityNumber = Convert.ToInt32 (Console.ReadLine());

void PrintNumber(int FirstNumber, int SecondNumber, int QuantityNumber)
{
    int count = 0;
    if (QuantityNumber > 0)
    {
        Console.Write(FirstNumber + SecondNumber + " ");
        count = FirstNumber;
        FirstNumber =SecondNumber;
        SecondNumber += count;
        PrintNumber(FirstNumber, SecondNumber, QuantityNumber -= 1);
    }
}

PrintNumber(FirstNumber, SecondNumber, QuantityNumber);