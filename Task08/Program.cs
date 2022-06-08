/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

using System;
using  static System.Console;

Clear();
WriteLine ("Программа выводит все четные числа от 1  до введенного числа");
Write ("Введите число: ");
int FirstNumber = Convert.ToInt32(ReadLine());
int N = FirstNumber / 2;
Write ("Все чётные числа от 1  до ");
Write (FirstNumber);
WriteLine (":");
int CurrentN = 0;
while (CurrentN < N)
{
    CurrentN ++;
    Write (CurrentN * 2);
    Write (", ");

}
WriteLine ("");