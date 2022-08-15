// Задача №42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string numbe1 = Console.ReadLine();

DateTime d1 = DateTime.Now;
Console.WriteLine(Convert.ToString(int.Parse(numbe1), 2));
Console.WriteLine(DateTime.Now - d1);

d1 = DateTime.Now;
Console.Write("Введите десятичное число: ");
int decemalNumber = ReadDecemalNumber();
PrintAnswer(BinaryConverter(decemalNumber));
Console.WriteLine(DateTime.Now - d1);


int ReadDecemalNumber()
{
    return int.Parse(numbe1 ?? "");
}

string BinaryConverter(int num)
{
    string bin = "";
    while (num > 0)
    {
        if (num % 2 == 1)
        {
            bin = "1" + bin;
        }
        else
        {
            bin = "0" + bin;
        }
        num /= 2;
    }
    return bin;
}

void PrintAnswer(string answer)
{
    Console.WriteLine("Введенное число в двоичном виде: " + answer);
}
