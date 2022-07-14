// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int startNumber = 2;
    string output = "";

    while (startNumber <= inputNumber)
    {
        output = output + startNumber + ", ";
        startNumber = startNumber + 2;
    }
    Console.WriteLine(output);
}