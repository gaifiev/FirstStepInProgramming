// Задача №37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// Например:
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(-1000, 1000);
        i++;
    }
    return outArray;
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

//Метод решения задачи 37 наивный
int[] ColculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    int i = 0;

    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }

    return resultArray;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int[] resultArray = ColculateTask(buferArray);
PrintIntArray(resultArray);