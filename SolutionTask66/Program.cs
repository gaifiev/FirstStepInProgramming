// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int numberM = ReadData("Задайте число M: ");
int numberN = ReadData("Задайте число N: ");
int buf = numberM;
if (numberM > numberN)
{
    numberM = numberN;
}

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine()!);
}

void NaturalNamberPrinter(int numberM, int numberN, int total)
{
    total = total + numberN;

    if (numberN <= numberM)
    {
        Console.Write(total);
        return;
    }

    NaturalNamberPrinter(numberM, numberN - 1, total);
}

NaturalNamberPrinter(numberM, numberN, buf = 0);