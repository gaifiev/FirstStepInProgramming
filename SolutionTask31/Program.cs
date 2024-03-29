﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например: в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Глобальыне переменные для накопления результата
int posetivSum = 0;
int negativSum = 0;

//Метод возвращает массив заполненый случайными числами от -9 до 9
int[] FillingArray()
{
    int[] outArray = new int[12]; //new выделить оперативную память под массив и указать размер массива (выходной массив)
    int i = 0; //буфферная переменная итератор
    System.Random numberSintezator = new System.Random(); //создать экземпляр класса рандомайзер
    while (i < 12) //цикл заполнения массива
    {
        outArray[i] = numberSintezator.Next(-9, 10); // создаем новое значение и обращаемся к элементу массива [i] и заполняем массив элементами
        i++; //увеличиваем инкремент
    }
    return outArray; //возвращает массив (значение)
}

//Метод подсчета положительных и отрицательных значений
void ColculateTask(int[] outArray) // и воид ... (должен принять массив)
{
    int i = 0; //буфферная переменная итератор
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            posetivSum += outArray[i]; //увеличиваем счетчик
        }
        else
        {
            negativSum += outArray[i];
        }
        i++;
    }
}

//Выводим результат на консоль
void PrintResult()
{
    Console.WriteLine(posetivSum);
    Console.WriteLine(negativSum);
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

//Метод решения задачи 31 наивный
void VariantNaive() //обернуть в метод 
{
    int[] bufferArray = FillingArray(); // к массиву присвоим в методы вернем
    PrintIntArray(bufferArray);
    ColculateTask(bufferArray);
    PrintResult();
}


//Метод решения задачи 31 простой
void VariantSimple()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    //Буфферные переменные
    int i = 0;
    int buf = 0;
    //Цикл заполнения массива
    while (i < 12)
    {
        //Получаем новое значение
        buf = numberSintezator.Next(-9, 9);
        Console.Write(buf + " ");
        //Накапливаем результат
        if (buf >= 0)
        {
            //Элемент положительный
            posetivSum += buf;
        }
        else
        {
            //Элемент отрицательный
            negativSum += buf;
        }
        //Увеличиваем инкремент
        i++;
    }
    Console.WriteLine();
    //Выводим сумму положительных значений
    Console.WriteLine(posetivSum);
    //Выводим сумму отрицательных значений
    Console.WriteLine(negativSum);
}

int t;

t = Environment.TickCount;
//Вариант 1
VariantNaive();
Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);

t = Environment.TickCount;
//Вариант 2
VariantSimple();
Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);