﻿// №34 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123 -> 1
// * Отсортировать массив методом пузырька

//Метод возвращает массив заполненый случайными положительными трехзначными числами
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

//Метод подсчета случайных положительных трехзначных значений
int Colculate(int[] inputArray)
{
    int buf = 0; //выведем выходную переменную 
    int i = 0; //буфферная переменная итератор
    while (i < inputArray.Length)//пробегаем по всем элементам массива
    {
        if (inputArray[i] % 2 == 0) //четные числа
        {
            buf++; //увеличиваем выходную
        }
        i++; //увеличиваем инкремент
    }
    return buf; //возвращает значение
}
int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Colculate(buferArray);
Console.WriteLine(Colculate(buferArray));