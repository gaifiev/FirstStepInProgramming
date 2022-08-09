//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();
Console.WriteLine("Введите число:");
string inputLineNumber = Console.ReadLine()!;
int inputNumber = int.Parse(inputLineNumber ?? "");
int numA = 0;
int numB = 0;
DateTime timePoint = DateTime.Now;
// первый вариант метода подсчета
void Conculate1(int inputNumber)
{
    while (inputNumber > 0)
    {
        numA += inputNumber % 10;
        inputNumber /= 10;
    }
}
// второй вариант метода подсчета
void Conculate2()
{
    char[] array = inputLineNumber!.ToCharArray();
    for (int i = 0; i < inputLineNumber.Length; i++)
    {

        numB += int.Parse(array[i].ToString());
    }

}

timePoint = DateTime.Now;
Conculate1(inputNumber);
Console.WriteLine("Сумма цифр в числе: " + numA);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
Conculate2();
Console.WriteLine("Сумма цифр в числе: " + numB);
Console.WriteLine(DateTime.Now - timePoint);