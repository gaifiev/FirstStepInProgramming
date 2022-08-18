// №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Например:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
//Базовое решение
Console.Clear();
// метод считывания в консоле
double[,] InputArray()
{
    Console.Write("Введите m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] outArray = new double[m, n];
    return outArray;
}
//метод заполнения массива случайными вещественными числами
void FillTwoDimArray(double[,] outArray)
{
    {
        for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
                outArray[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
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
void PrintColorTwoDimArray(double[,] outArray)
{
    int i = 0;
    int j = 0;
    while (i < outArray.GetLength(0))
    {
        j = 0;
        while (j < outArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(outArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

double[,] outArray = InputArray();
FillTwoDimArray(outArray);
PrintColorTwoDimArray(outArray);
