// Напишите программу, 
// которая будет принимать на вход число и возвращать сумму его цифр.

Console.Clear();
int number = ReadData("Задайте число: ");

Console.WriteLine(Sum(number));

int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// 12345
// 1 5    out 5
// 2 1234 out 4
// 3 123  out 3
// 4 12   out 2
// 5 1    out 1
// 6 0    out 0
// 7 0    out 0
// num%10+(num/10)%10+((num/10)/10)%10 .. 

int Sum(int num)
{
    if (num > 0)
    {
        return num % 10 + Sum(num / 10);
    }
    else
    {
        return 0;
    }
}