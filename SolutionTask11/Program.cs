//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//первый вариант решения
void variant1()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Число:" + number);
    int numberSecondDigit = number / 100;
    int numberThirdDigit = number % 10;
    Console.WriteLine("Число после удаления второй цифры: " + numberSecondDigit + numberThirdDigit);
}


//Второй вариант решения
void variant2()
{
    int number = new Random().Next(100, 1000);
    Console.Write("Рандом число это: ");
    Console.WriteLine(number);
    string stringNum = number.ToString();
    Console.Write("modified num is : :");
    Console.Write(stringNum[0]);
    Console.WriteLine(stringNum[2]);
}

//Третий вариант решения
void variant3()
{
    int number = new Random().Next(100, 1000);
    Console.Write("Рандом число это: ");
    Console.WriteLine(number);

    int num1 = number / 100;
    int num2 = number % 10;

    Console.Write("modified num is : :");
    Console.WriteLine(num1 * 10 + num2);
}

variant1();
variant2();
variant3();