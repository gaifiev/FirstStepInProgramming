// Задача №51
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
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

int CalcDiagTwoDimArr(int[,] inputArray)
{
    int outSumDiaganal = 0;

    int i = 0;
    while (i < inputArray.GetLength(0))
    {
        outSumDiaganal += inputArray[i, i];
        i++;
    }

    return outSumDiaganal;
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
            Console.Write(inputArray[i, j] + "\t");
            Console.ResetColor();
            j++;
        }
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }


}



int[,] twoDimArray = FillTwoDimArray(7, 14);
PrintColorTwoDimArray(twoDimArray);
//----------------------------------------------------------
int sum = CalcDiagTwoDimArr(twoDimArray);
//----------------------------------------------------------
Console.WriteLine(sum);
//----------------------------------------------------------