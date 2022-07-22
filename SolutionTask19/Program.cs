// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
int cont1;
int cont2;
int cont3;
int cont4;
int cont5;
void readHit()
{
    Console.Write("Введите пятизначное число: ");
    int numberA = int.Parse(Console.ReadLine());
    cont1 = numberA / 10000;
    cont2 = (numberA / 1000) % 10;
    cont3 = (numberA / 100) % 10;
    cont4 = (numberA / 10) % 10;
    cont5 = numberA % 10;
}
void printOut()
{
    if (cont1 == cont5 && cont2 == cont4)
    {
        Console.WriteLine("Является палиндромом");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }
}
readHit();
printOut();