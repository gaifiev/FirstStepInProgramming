﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string? numA = Console.ReadLine(); //считываем переменную
char[] numB = numA!.ToCharArray(); //превращение переменной в массив с типом char
if (numB.Length > 2) //проверка условия, длина массива больше 2, то выведет в консоль, а есл не больше 2, то выведет "нет третьей цифры"
{
    Console.WriteLine(numA[2]); // если да, то выведет третье число
}
else //если нет, то выводит в консоль
{
    Console.WriteLine("Третьей цифры нет");
}
