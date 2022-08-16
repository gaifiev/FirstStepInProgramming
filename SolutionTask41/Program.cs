// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например: 
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

Console.Write($"Введите с клавиатуры M чисел: ");
int a = int.Parse(Console.ReadLine()!);
int[] arrayA = new int[a];

int[] Read(int a)
{

    for (int i = 0; i < a; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayA[i] = int.Parse(Console.ReadLine()!);
    }
    return arrayA;
}

int Conculate(int[] arrayA) //вычисление больше нуля
{
    int j = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i] > 0) j += 1;
    }
    return j;
}
void PrintResult()
{
    Console.WriteLine($"Всего чисел больше нуля ввёл пользователь: {(Conculate(arrayA))} ");
}
int[] test = Read(a);
Conculate(test);
PrintResult();
