// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например: 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// * Найдите площадь треугольника образованного пересечением 3 прямых

int k1;
int k2;
int b1;
int b2;
int coordsX = 0;
int coordsY = 0;
string coords;

void Read() // метод ввода значений
{
    Console.WriteLine("Введите значение b1");
    b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k1");
    k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    k2 = Convert.ToInt32(Console.ReadLine());
}

void Conculate()//метод вычисления
{
    if ((k1 == k2) && (b1 == b2))

        Console.WriteLine("Прямые совпадают");
    else
        if (k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        coordsX = (k2 - b1) / (k1 - k2);
        coordsY = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    }
    coords = "Координаты точки пересечения: " + coordsX + "," + coordsY;
}

void PrintResult()
{
    Console.WriteLine(coords);
}
Read();
Conculate();
PrintResult();