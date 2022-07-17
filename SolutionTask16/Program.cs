// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Например: 5, 25 - Да
// -4, 16 - Да
// 25, 5 - да
// 8, 9 - нет

Console.Clear();

Console.WriteLine("Введите первое число:");
string? inputFirst = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string? inputSecond = Console.ReadLine();

if ((inputFirst != null) && (inputSecond != null))
{
    int inputNumberFirst = int.Parse(inputFirst);
    int inputNumberSecond = int.Parse(inputSecond);
    int a = inputNumberFirst * inputNumberFirst;
    int b = inputNumberSecond * inputNumberSecond;
    if ((a == inputNumberSecond) || (b == inputNumberFirst))
    {
        Console.WriteLine("Да!");
    }
    else
    {
        Console.WriteLine("Нет!");
    }

}