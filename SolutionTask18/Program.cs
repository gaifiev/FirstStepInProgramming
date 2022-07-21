// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти(x и y).
void printAnswer(int number)
{
    if (number == 1) Console.WriteLine("Допустимо: x>0, y>0");
    if (number == 2) Console.WriteLine("Допустимо: x<0, y>0");
    if (number == 3) Console.WriteLine("Допустимо: x<0, y<0");
    if (number == 4) Console.WriteLine("Допустимо: x>0, y<0");
}


string? inputLine = Console.ReadLine(); //считаем строку в консоле

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine); //превращаем в строчку
    printAnswer(inputNumber);
}
