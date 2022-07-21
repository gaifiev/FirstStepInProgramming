//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int coordsXPointA;
int coordsYPointA;
int coordsXPointB;
int coordsYPointB;
double lengthAB;

//считывает координаты точек А и B
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точки А");
    coordsXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordsYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordsXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordsYPointB = int.Parse(Console.ReadLine());
}

//вычисляет расстояние между точками А и В
void conculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordsXPointA - coordsXPointB), 2) + Math.Pow((coordsYPointA - coordsYPointB), 2));
}

readDataOfPoint();
conculateLengthAB();

Console.WriteLine(lengthAB);
