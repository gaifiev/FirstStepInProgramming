// Рекурсия


// РЕПКА(200Н силы): Дед(100Н силы)-Бабка(50Н силы)-Внучка(25)
//                   -Жучка(12Н )-Машка(12Н)-Мышка(1Н)Stop

// void Power(int askedPower)
// {
//     if(askedPower>out1)
//     {
//         return;
//     }
//     else
//     {
//         Power(askedPower);
//     }
// }
Console.Clear();
int ReadData()
{
    Console.WriteLine("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

//Стек
//1 4 - 3 out
//2 3 - 2 out 2
//3 2 -   out 1

int NuturalNumberPrinter(int num)
{
    if (num == 2) return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NuturalNumberPrinter(num) + " ");
    }
    return num;
}

int inputNumber = ReadData();
NuturalNumberPrinter(inputNumber + 2);