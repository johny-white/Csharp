/*
Задайте массив. Напишите программу, которая орпделеяет, присутствует ли заданное числов массиве.
Программа должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[ -4 3 4 1], 3 => Да

int[] array = { 1, 3, 4, 19, 3 };
Console.Write("Введите число для поиска: ");
int x = Convert.ToInt32(Console.ReadLine());
int v = 0;
foreach (int e in array)
{
    if (e == x) { v = x; }
}

for (int i = 0; i < array.Length; i++)
{ if (array[i] == x) { v = x; } }
if (v == x)
{ Console.Write("Да"); }
else
{
    Console.Write("Нет");
}
---------------------------
*/
/* Задайте массив из элеметнов, заполненных числами из промежутка [-10, 10]. 
Замените отрицательные элементы на положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/

int[] arr = new int[10];

for (int i = 0; i < 10; i++)
{
    arr[i] = new Random().Next(-10, 11);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    arr[i] = arr[i] * -1;
    Console.Write($"{arr[i]} ");
}