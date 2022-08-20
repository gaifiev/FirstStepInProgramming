// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. 
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
            Console.Write(inputArray[i, j] + "\t");
            j++;
        }
        Console.WriteLine();
        i++;
    }
}

// Метод меняет местами первую и последнюю строки
// Принимает двумерный массив
// Возвращает модифицированный входной массив
int[,] RotateRowFirstLast(int[,] inputArray)
{
    int bufferElement = 0;
    int j = 0;
    while (j < inputArray.GetLength(1))
    {
        //Блок ротации элементов в столбце
        bufferElement = inputArray[0, j];
        inputArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        inputArray[inputArray.GetLength(0) - 1, j] = bufferElement;
        j++;
    }
    return inputArray;
}
int[,] twoDimArray = FillTwoDimArray(3, 4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
PrintTwoDimArray(RotateRowFirstLast(twoDimArray));