// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void variant1()
{
    // создаем переменную = считываем данные с консоли
    string? inputLine = Console.ReadLine();
    if (inputLine != null) //сравнение переменной со значением
    {
        int numberA = int.Parse(inputLine); //Превращаем в строку
        int numberB = (numberA % 100) / 10; //объявлем вводимое значение
        Console.WriteLine(numberB); //выведет в консоль результат
    }
}

void variant2()
{
    int numberA = int.Parse(Console.ReadLine()!); //создаем переменную и превращаем в строку со считыванием данных с консоли
    Console.WriteLine(numberA); //выводит в консоль
    int numberB = (numberA % 100) / 10; //объявляем вводимое значение
    Console.WriteLine(numberB); //выводит результат
}

void variant3()
{
    int inputLineA = Convert.ToInt32(Console.ReadLine()); //создаем переменную и превращаем строку в число и считываем данные с консоли
    string inputLineB = Convert.ToString(inputLineA); //превращаем число в строку
    Console.WriteLine("Вторая цифра: " + inputLineB[1]);//выводит результат в консоль
}

void variant4()
{
    int number(int a) //Метод
    {
        int result = a / 10 % 10; //объявляем вводимое значение
        return result; //возвращает результат
    }

    int a = Convert.ToInt32(Console.ReadLine()); //Создаем переменную и превращаем строку в число
    int result = number(a); //Использует метод, потом в метод добавляет параметр
    Console.WriteLine(result); // Выводит результат на консоль
}
variant1();
variant2();
variant3();
variant4();