//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
string? inputNumber1 = Console.ReadLine();
string? inputNumber2 = Console.ReadLine();
string? inputNumber3 = Console.ReadLine();
int num1 = int.Parse(inputNumber1);
int num2 = int.Parse(inputNumber2);
int num3 = int.Parse(inputNumber3);
if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Максимальное число = {num1}");
}
else
if (num2 > num3)
{
    Console.WriteLine($"Максимальное число =  {num2}");
}
else
{
    Console.WriteLine($"Максимальное число =  {num3}");
}
Console.WriteLine();