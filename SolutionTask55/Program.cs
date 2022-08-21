// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// void Read()
// {
//     Console.WriteLine("Введите число А: ");
//     int a = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Вы ввели число " + a);

//     Console.WriteLine("Введите число B: ");
//     int b = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Вы ввели число " + b);

//     Console.WriteLine("Введите число C: ");
//     int c = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Вы ввели число " + c);
// }

// int ReadCoord(string line)
// {
//     Console.WriteLine(line);
//     int buf = int.Parse(Console.ReadLine());
//     Console.WriteLine("Вы ввели число " + buf);
//     return buf;
// }

// int a = ReadCoord("Введите число А: ");
// int b = ReadCoord("Введите число B: ");
// int c = ReadCoord("Введите число C: ");


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

void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

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

// Метод меняет местами первую ипоследнюю строчку
// Принимает двумерный массив
// Возвращает модефицированный входной массив
int[,] RotateTwoDimArray(int[,] inputArray)
{
    int bufferElement = 0;
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = i;
        while (j < inputArray.GetLength(0))
        {
            //Блок ротации элементов в столбце
            bufferElement = inputArray[i, j];
            inputArray[i, j] = inputArray[j, i];
            inputArray[j, i] = bufferElement;
            j++;
        }
        i++;
    }
    return inputArray;
}


int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

if (twoDimArray.GetLength(0) != twoDimArray.GetLength(1))
{
    Console.WriteLine("Данный массив перевернуть нельзя!");
}
else
{
    //----------------------------------------------------------
    PrintTwoDimArray(RotateTwoDimArray(twoDimArray));
    //----------------------------------------------------------
}