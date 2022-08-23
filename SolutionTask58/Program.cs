// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.Clear();
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void FillTwoDimArray1(int[,] array) //метод для заполнения двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 101);
        }
    }
}

void PrintArray(int[,] inputArray)
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
    Console.WriteLine();
}

void Multiplication(int[,] matrix1, int[,] matrix2, int[,] total)
{
    for (int i = 0; i < total.GetLength(0); i++)
    {
        for (int j = 0; j < total.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            total[i, j] = sum;
        }
    }
}

int[,] firstArray = new int[5, 5];
FillTwoDimArray1(firstArray);
PrintArray(firstArray);

int[,] twoArray = new int[5, 5];
FillTwoDimArray1(twoArray);
PrintArray(twoArray);

int[,] total = new int[5, 5];
Multiplication(firstArray, twoArray, total);
PrintArray(total);

