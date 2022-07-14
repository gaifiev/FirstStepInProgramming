// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
string? inputLine = Console.ReadLine();
int num1 = int.Parse(inputLine);
if (num1 % 2 == 0)
{
    Console.WriteLine($"Чётное число ");
}
else
{
    Console.WriteLine($"Не чётное число");
}
Console.ReadLine();