// Задача №44 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Fn-1+Fn-2=Fn

Console.Write("Введите количество чисел в ряде Фибоначчи: ");
int decemalNumber = ReadDecemalNumber();
string outLine = Fibonnaci(decemalNumber);
PrintAnswer(outLine);


int ReadDecemalNumber() //первый метод это чтение данных
{
    return int.Parse(Console.ReadLine() ?? ""); //вводится число с клавиатуры в терминале и парсит 
}

string Fibonnaci(int n) //собирает число фибоначи. Принимает метод на вход число, которое получили от введеного пользователем
{
    string answer = ""; //резервирует переменное

    if (n == 2) //если n равно null(2)
    {
        answer = "0 1";
    }
    else if (n == 1) //если n равно null(1)
    {
        answer = "0";
    }
    else
    {
        answer = "0 1";
        int fn_1 = 1;
        int fn_2 = 0;
        int fn;
        for (int i = 0; i < n - 2; i++)
        {
            fn = fn_1 + fn_2;
            answer += " " + fn;
            fn_2 = fn_1;
            fn_1 = fn;
        }
    }
    return answer;
}
// печатает массив
void PrintAnswer(string answer)
{
    Console.WriteLine("Ряд Фибоначчи для заданного кол-ва чисел: " + answer);
}