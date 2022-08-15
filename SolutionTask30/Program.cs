//Напишите программу, которая выводит массив из 8 элементов, заполенный нулями и единицами в случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

System.Random numberSintezator = new System.Random();

void VariantNaive()
{
    int i = 0;
    Console.Write("[");
    while (i < 8)
    {
        Console.Write(numberSintezator.Next(0, 2) + ",");
        i++;
    }
    Console.Write(numberSintezator.Next(0, 2));
    Console.Write("]");
}

VariantNaive();