// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();
int numberM = ReadData("Задайте число M: ");
int numberN = ReadData("Задайте число N: ");

if (numberM < numberN)
{
    NaturalNamberPrinter(numberM, numberN);
}
else
{
    NaturalNamberPrinter(numberN, numberM);
}


int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine()!);
}

void NaturalNamberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNamberPrinter(m + 1, n);
}