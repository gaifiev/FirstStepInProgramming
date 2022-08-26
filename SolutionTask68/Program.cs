// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();
int numberM = ReadData("Задайте число M: ");
int numberN = ReadData("Задайте число N: ");

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine()!);
}

int FunctionAkkerPrinter(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else
    if (numberN == 0) return FunctionAkkerPrinter(numberM - 1, 1);
    else return FunctionAkkerPrinter(numberM - 1, FunctionAkkerPrinter(numberM, numberN - 1));
}
int total = FunctionAkkerPrinter(numberM, numberN);
Console.Write(total);
