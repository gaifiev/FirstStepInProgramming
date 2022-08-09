// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int coordsXPointA;
int coordsYPointA;
int coordsXPointB;
int coordsYPointB;
int coordsZPointA;
int coordsZPointB;
double lengthABZ;

//считывает в консоле координаты точек А и B и Z и парсим
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точки А");
    coordsXPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordsYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки A");
    coordsZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordsXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordsYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordsZPointB = int.Parse(Console.ReadLine());
}

//вычисляет расстояние между точками А и В и Z
void calculateLengthABZ()
{
    lengthABZ = Math.Sqrt(Math.Pow((coordsXPointA - coordsXPointB), 2) + Math.Pow((coordsYPointA - coordsYPointB), 2) + Math.Pow((coordsZPointA - coordsZPointB), 2));
}

readDataOfPoint();
calculateLengthABZ();

Console.WriteLine(lengthABZ); //выводит результат