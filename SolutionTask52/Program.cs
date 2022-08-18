// №52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Дополнительно вывести среднее арифметическое по диагоналям и диагональ выделить разным цветом.
Console.Clear();
// считываем в консоле
int[,] outArray = new int[5, 5];
//метод заполнения массива случайными числами
void FillTwoDimArray(int[,] outArray)
{
    {
        for (int i = 0; i < outArray.GetLength(0); i++)
        {
            for (int j = 0; j < outArray.GetLength(1); j++)
            {
                outArray[i, j] = new Random().Next(0, 100) / 10;
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
// проверка
void InputArray(int[,] outArray)
{
    for (int j = 0; j < outArray.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < outArray.GetLength(0); i++)
        {
            avg = (avg + outArray[i, j]);
        }
        avg = avg / outArray.GetLength(0);
        Console.Write("[ " + avg + " ]");
    }
}
FillTwoDimArray(outArray);
PrintColorTwoDimArray(outArray);
InputArray(outArray);

