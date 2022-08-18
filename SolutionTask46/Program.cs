// Задача №46 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Например:
// m = 3, n = 4.
// -1 4 8 19
// 5 -2 33 -2
// -77 3 8 1
Console.Clear();
// метод для заполнения двумерного массива (строка, столбец)
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random(); // обьявили рандом
    int i = 0; //итераторы
    int j = 0;
    int[,] outArray = new int[countRow, countColumn]; // массив который заполняет
    while (i < countRow)  //проход по внешнему индексу (по строчкам) "внешний цикл"
    {
        j = 0;
        while (j < countColumn)//проходит по внутреннему индексу (по столбцам) "внутренний цикл" 
        {
            outArray[i, j] = numberSyntezator.Next(0, 101); //заполняет массив (генератор чисел)
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " "); //печатает все элементы
            j++;
        }
        // Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + " ");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
PrintColorTwoDimArray(twoDimArray);