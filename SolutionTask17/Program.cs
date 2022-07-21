//Метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
    string inputLine = Console.ReadLine(); //считает строку в консоле

    //x=34; y=-30 -> 4  вводимые значения

    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";")); //мы отрезаем от нуля строки до точки запятой, сабстринг это подстрока. В переменной инпутлайн выделить подстроку с нуля до точки с запятой
    //x=34
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1); //в переменной кордлайн будет лежать значение х=34. "Х=" нужно избавиться. Отрезает подстроку от равно до конца строки

    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    //y=-30
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);  //разобрали, распарсили 4 строчки выше. в переменной кордлайн будет лежать значение y=-30. "y=" нужно избавиться. Отрезает подстроку от равно до конца строки

    //Console.WriteLine(coordX + " " + coordY);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine); //превратили значение в вещественные числа

    int[,] arrayOut = new int[1, 2]; //кладем числа в массив, здесь строчки
    arrayOut[0, 0] = coordX; // здесь столбцы. в первом столбце значение 0 кладем Х(0,0, не строка, а столбцы) значение, а во втором кладем Y(0,1) значение. 
    arrayOut[0, 1] = coordY; //заполнили многомерный массив

    return arrayOut; //выдаем на выход 
}
//Печатает номер четверти
void printQuter(int[,] arrayPoint)
{
    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("1 четверть");

    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("2 четверть");

    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("3 четверть");

    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("4 четверть");

}

int[,] arrayPoint = readPoint();

printQuter(arrayPoint);

//printQuter(readPoint());