// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
Console.Clear();

int inputNumberA = ReadNumber("Введите число A: ");
int inputNumberB = ReadNumber("Введите число B: ");

DateTime d = DateTime.Now;
int res1 = PowNumber(inputNumberA, inputNumberB);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
int res2 = MyPow(inputNumberA, inputNumberB);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
double res3 = Math.Pow(inputNumberA, inputNumberB);
Console.WriteLine(DateTime.Now - d);

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(res3);

// 2*2*2*2*2*2*2*2
// 16*16
// 4*4     4*4
// 2*2 2*2 2*2 2*2

int MyPow(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, (b / 2) + 1);
    }
}

// 2 4
// 1 2 4 out 2 *
// 2 2 3 out 2 *
// 3 2 2 out 2 *
// 4 2 1 out 2


int PowNumber(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumber(a, --b);
}

int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}
