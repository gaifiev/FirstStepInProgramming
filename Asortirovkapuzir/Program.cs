// Задача со звездочкой* 34 Отсортировать массив методом пузырька
//Метод возвращает массив заполненый случайными положительными трехзначными числами
int[] FillingArray()
{
    Console.Write("Генерируем случайные трехзначные числа: "); //выводит в консоль
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


int[] Sortirovka(int[] array) //сортировка по элементам
{
    Console.Write("Сортируем числа пузырьком: "); //выводит в консоль
    int temp = 0; //буфферный переменный итератор
    //сравнение
    for (int i = 0; i < array.Length; i++)
    {
        for (int b = i + 1; b < array.Length; b++)
        {
            if (array[i] > array[b])//сравнение между двумя числами
            {
                temp = array[i];
                array[i] = array[b];
                array[b] = temp; //меняет местами
            }
        }
    }
    return array; //возвращает массив
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
    Console.Write("Всего четные трехзначные числа: ");
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
int[] temp1 = Sortirovka(buferArray);
PrintIntArray(temp1);
Console.WriteLine(Colculate(temp1));