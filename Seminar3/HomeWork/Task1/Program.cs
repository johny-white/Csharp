/*
Задайте одномерный массив из 10 целых
чисел от 1 до 100. Найдите количество элементов
массива, значения которых лежат в отрезке [20,90].
Пример
массив [10 21 14 93 23] => 2
*/

int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 101);
    Console.Write($"{arr[i]} ");
}
System.Console.WriteLine();
int count = 0;
foreach (int e in arr)
{
    if (e >= 20 && e <= 90)
    {
        count++;
    }
}
Console.Write($"{count} ");