﻿/*
Задайте массив. Напишите программу, которая орпделеяет, присутствует ли заданное числов массиве.
Программа должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[ -4 3 4 1], 3 => Да
*/
int[] array = { 1, 3, 4, 19, 3 };
Console.Write("Введите число для поиска: ");
int x = Convert.ToInt32(Console.ReadLine());
int v = 0;

foreach (int e in array)
{
    if (e == x) { v = x; }
}

if (v == x)
{ Console.Write("Да"); }
else
{
    Console.Write("Нет");
}