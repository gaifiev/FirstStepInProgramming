﻿// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

//Метод возвращает массив заполненый случайными числами
int[] FillingArray()
{
    int[] outArray = new int[4]; //new выделить оперативную память под массив и указать размер массива (выходной массив)
    int i = 0;//буфферная переменная итератор
    System.Random numberSintezator = new System.Random(); //создать экземпляр класса рандомайзер
    while (i < 4) //цикл заполнения массива
    {
        outArray[i] = numberSintezator.Next(100, 1000); // создаем новое значение и обращаемся к элементу массива [i] и заполняем массив элементами
        i++; //увеличиваем инкремент
    }
    return outArray; //возвращает массив (значение)
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

//Метод подсчета случайных значений
int Colculate(int[] inputArray)
{
    int buf = 0; //объявляем выходную переменную которую будем накапливать
    int i = 1; //буфферная переменная итератор
    while (i < inputArray.Length)//пробегаем по всем элементам массива
    {
        buf = buf + inputArray[i]; //суммировать элементы
        i += 2; //увеличиваем инкремент
    }
    return buf; //возвращает значение
}
int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Colculate(buferArray);
Console.WriteLine(Colculate(buferArray));