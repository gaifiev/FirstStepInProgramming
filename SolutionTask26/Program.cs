//Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// Например:
// 456 = 3
// 78 = 2
// 89126 = 5
Console.Clear();
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine() ?? "";
int inputNumber = int.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;

int VariantChar()
{
    // int numberLength = 0;
    // char[] array = inputLineNumber.ToCharArray();
    // numberLength = array.Length;

    return inputLineNumber.ToCharArray().Length;
}

int VariantSimple()
{
    int numberLength = 0;
    int digits = 1;
    while (digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;
    }
    return numberLength;
}

int VariantLog10()
{
    return (int)Math.Log10(inputNumber) + 1;
}

int result = 0;

timePoint = DateTime.Now;
result = VariantChar();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantSimple();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);

timePoint = DateTime.Now;
result = VariantLog10();
Console.WriteLine(result);
Console.WriteLine(DateTime.Now - timePoint);
