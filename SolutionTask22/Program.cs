//Напишите программу, которая, принимает на вход число(N) и выдает таблицу квадратов чисел от 1 до N.
// Например:
// 5->1,4,16,25.
// 2->1,4

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNN = string.Empty;
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNN = lineNN + (s * s).ToString() + " ";
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}

