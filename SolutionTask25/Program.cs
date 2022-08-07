//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16
int cont1;
int cont2;
void Read()
{
    Console.Write("Введите первое число: ");
    cont1 = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    cont2 = int.Parse(Console.ReadLine());
}


int Conculate1(int cont1, int cont2)
{
    int total = 1;
    total = (int)Math.Pow(cont1, cont2);
    return total;
}

int Conculate2(int cont1, int cont2)
{
    int i = 0;
    int total = 1;
    while (i < cont2)
    {
        total = total * cont1;
        i++;
    }
    return total;
}
void Print()
{
    Console.WriteLine("Первый способ считывания: " + "[" + $"{cont1}" + "] " + "возводим в натуральную степень ^" + $"{cont2}" + " = " + Conculate1(cont1, cont2));
    Console.WriteLine("Первый способ считывания: " + "[" + $"{cont1}" + "] " + "возводим в натуральную степень ^" + $"{cont2}" + " = " + Conculate2(cont1, cont2));
}

Read();
Conculate1(cont1, cont2);
Conculate2(cont1, cont2);
Print();