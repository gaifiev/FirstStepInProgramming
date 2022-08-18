// Задача №49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
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

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + " ");
            j++;
        }
        //Console.Write("\n");
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
    int i = 0; int j = 0;



    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }


}

int[,] UpdateTwoDimArray(int[,] inputArray)
{
    int[,] outArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                outArray[i, j] = inputArray[i, j] * inputArray[i, j];
            }
            else
            {
                outArray[i, j] = inputArray[i, j];
            }
            j++;
        }
        i++;
    }

    return outArray;
}

void UpdateTwoDimArrayNataliaVersion(ref int[,] inputArray)
{
    int i = 0; int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            inputArray[i, j] = inputArray[i, j] * inputArray[i, j];
            j += 2;
        }
        i += 2;
    }
}


int[,] twoDimArray = FillTwoDimArray(10, 10);
PrintColorTwoDimArray(twoDimArray);
//----------------------------------------------------------
DateTime d = DateTime.Now;
int[,] bufTwoDimArray = UpdateTwoDimArray(twoDimArray);
Console.WriteLine(DateTime.Now - d);

d = DateTime.Now;
UpdateTwoDimArrayNataliaVersion(ref twoDimArray);
Console.WriteLine(DateTime.Now - d);
//----------------------------------------------------------
PrintColorTwoDimArray(bufTwoDimArray);
PrintColorTwoDimArray(twoDimArray);
//----------------------------------------------------------