/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

using System;
using  static System.Console;

Clear();
WriteLine ("Программа сообщает является ли введенное число четным");
Write ("Введите число: ");
int FirstNumber = Convert.ToInt32(ReadLine());

if (FirstNumber%2 != 1)
{
    Write ("Введенное число ");
    Write (FirstNumber);
    WriteLine (" является Чётным");
}
else
{
    Write ("Введенное число ");
    Write (FirstNumber);
    WriteLine (" НЕ является Чётным");
}