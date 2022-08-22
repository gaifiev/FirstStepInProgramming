// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

int[,] FillTwoDimArray(int countRow, int countColumn) //метод для заполнения двумерного массива
{
    System.Random numberSyntezator = new System.Random();
    int i = 0;
    int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            Thread.Sleep(10);
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

int FindRow(int[,] inputArray, int a) //сумма каждой строки
{

    int sum = inputArray[a, 0];
    for (int i = 1; i < inputArray.GetLength(1); i++)
    {
        sum = sum + inputArray[a, i];
    }
    return sum;
}
int FindMinSumLine(int[,] inputArray) //поиск строки с наименьшей суммой элементов
{
    int min = 0;
    int b = FindRow(inputArray, 0);
    for (int i = 1; i < inputArray.GetLength(0); i++)
    {
        int temp = FindRow(inputArray, i);
        if (b > temp)
        {
            b = temp;
            min = i;
        }
    }
    Console.WriteLine($"{min + 1}");
    return min;
}

int[,] twoDimArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
FindMinSumLine(twoDimArray);