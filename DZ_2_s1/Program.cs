//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
string? inputNumber1 = Console.ReadLine();
string? inputNumber2 = Console.ReadLine();
int num1 = int.Parse(inputNumber1);
int num2 = int.Parse(inputNumber2);
if (num1 > num2)
{
    Console.WriteLine($"Минимальное число = {num2}");
    Console.WriteLine($"Максимальное число = {num1}");
}
else
if (num1 < num2)
{
    Console.WriteLine($"Минимальное число = {num1}");
    Console.WriteLine($"Максимальное число = {num2}");
}
else
    Console.WriteLine();