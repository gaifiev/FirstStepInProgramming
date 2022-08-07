Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Второе число");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Выберите каким способом хотите посчитать: 1. Сложение  2. Вычитание  3. Умножение 4.Деление 5. Возведение в степень");
// калькулятор через свитч кейс
int calculator = int.Parse(Console.ReadLine()!);
int total = 0;
switch (calculator)
{
    case 1:
        total = num1 + num2;
        Console.WriteLine($"Результат операции: {total}");
        break;
    case 2:
        total = num1 - num2;
        Console.WriteLine($"Результат операции: {total}");
        break;
    case 3:
        total = num1 * num2;
        Console.WriteLine($"Результат операции: {total}");
        break;
    case 4:
        total = num1 / num2;
        Console.WriteLine($"Результат операции: {total}");
        break;
    case 5:
        total = (int)Math.Pow(num1, num2);
        Console.WriteLine($"Результат операции: {total}");
        break;
    default:
        Console.WriteLine("Моя твоя не понимать");
        break;
}