/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


using System;
using  static System.Console;

Clear();
WriteLine ("Программа производит сравнение двух введенных чисел и выводит на экран бОльшее из двух");

Write ("Введите первое число: ");
int FirstNumber = Convert.ToInt32(ReadLine());
Write ("Введите второе число: ");
int SecondNumber = Convert.ToInt32(ReadLine());

if (FirstNumber > SecondNumber)
{
    Write ("Первое из введенных чисел больше второго ");
    WriteLine (FirstNumber);
}
else
{
    Write ("Второе из введенных чисел больше первого ");
    WriteLine (SecondNumber);
}
