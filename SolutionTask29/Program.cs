//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// считываем в консоли длину массива
Console.WriteLine("Введите длину массива:");
int lenghtArray = Convert.ToInt32(Console.ReadLine());

// считываем в консоли минимальный диапазон массива
Console.WriteLine("Введите минимальное значение диапазона массива:");
int minimumRangeArray = Convert.ToInt32(Console.ReadLine());

// считываем в консоли максимальный диапазон массива
Console.WriteLine("Введите максимальное значение диапазона массива:");
int maximumRangeArray = Convert.ToInt32(Console.ReadLine());

// создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

int i = 0; //буфферные переменные
void Read(int lenghtArray, int minimumRangeArray, int maximumRangeArray) //генерация чисел массвиа
{
    Console.Write("[");
    // цикл заполнения массива элементами
    while (i < lenghtArray - 1)
    {
        Console.Write(numberSintezator.Next(minimumRangeArray, maximumRangeArray) + ", "); //для проверки
        i++; //инкремент
    }
    Console.Write(numberSintezator.Next(minimumRangeArray, maximumRangeArray)); //выводит сгенерированный массив от мин до макс диапазоны
    Console.Write("]");
}

Read(lenghtArray, minimumRangeArray, maximumRangeArray);