// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// {1,9,9,0,2,8,0,9}
// 0 встречается 2 раза
// 1 встречается 1 раз 
// 2 встечается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// array = [1,2,3,4,2,1,3,2,4,2,3,7]
// alphabet = [1,2,3,4,7]
// freqmancy = [2,4,3,2,1]


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
            outArray[i, j] = numberSyntezator.Next(0, 10);
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
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

// Метод меняет местами первую ипоследнюю строчку
// Принимает двумерный массив
// Возвращает модефицированный входной массив
int[] FreqmancyCollect(int[,] inputArray, int alphabetLength)
{
    int[] resultArray = new int[alphabetLength];
    int i = 0;
    int j = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(0))
        {
            // array = [1,2,3,4,2,1,3,2,4,2,3,7]
            // alphabet = [1,2,3,4,7]
            // freqmancy = [2,4,3,2,1]

            //Собираем частоту появления элементов
            resultArray[inputArray[i, j]]++;
            j++;
        }
        i++;
    }
    return resultArray;
}


int[,] twoDimArray = FillTwoDimArray(10, 10);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();

int[] freqmancy = FreqmancyCollect(twoDimArray, 10);
PrintIntArray(freqmancy);

