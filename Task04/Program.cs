/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;
using  static System.Console;

Clear();
WriteLine ("Программа производит сравнение трех введенных чисел и выводит на экран максимальное");
Write ("Введите первое число: ");
int FirstNumber = Convert.ToInt32(ReadLine());
Write ("Введите второе число: ");
int SecondNumber = Convert.ToInt32(ReadLine());
Write ("Введите третье число: ");
int ThirdNumber = Convert.ToInt32(ReadLine());

int MaxNumber = FirstNumber;
if ( SecondNumber > MaxNumber)
{
    MaxNumber = SecondNumber;
    if (ThirdNumber > MaxNumber )
    {
        MaxNumber = ThirdNumber;
    }
}
else
{
    if (ThirdNumber > MaxNumber )
    {
        MaxNumber = ThirdNumber;
    }
}
Write("Максимальное из введенных чисел - ");
WriteLine (MaxNumber);
