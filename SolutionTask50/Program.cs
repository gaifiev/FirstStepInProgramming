// №50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру

//Базовое решение
Console.Clear();
// метод считывания в консоле
int[,] InputArray()
{
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] outArray = new int[9, 9];
    if (n > outArray.GetLength(0) || m > outArray.GetLength(1))
    {
        Console.WriteLine("Элемент не найден");
    }
    else
    {
        Console.WriteLine($"Найден элемент: {outArray[n, m]}"); //интерполяция
    }

    return outArray;
}
//метод заполнения массива случайными числами
void FillTwoDimArray(int[,] outArray)
{
    {
        for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
                outArray[i, j] = new Random().Next(0, 101) / 10;
            }
        }
    }
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
//метод для печати двумерного массива
void PrintColorTwoDimArray(int[,] outArray)
{
    int i = 0;
    int j = 0;
    while (i < outArray.GetLength(0))
    {
        j = 0;
        while (j < outArray.GetLength(1))
        {
            Console.Write("[ ");
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(outArray[i, j] + " ");
            Console.ResetColor();
            j++;
            Console.Write("]");
        }
        Console.WriteLine();
        i++;
    }
}

int[,] outArray = InputArray();
FillTwoDimArray(outArray);
PrintColorTwoDimArray(outArray);
