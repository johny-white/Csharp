/* Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее
a = 5; b = 7 -> min = 5; max = 7
a = 2; b = 10 -> min = 2; max = 10
a = -9; b = -3 -> min =-9; max = -3
*/
Console.WriteLine("Введите два числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("макс="+number1);
}
else
{
    Console.WriteLine("мин="+number1);
}
if (number1 < number2)
{
    Console.WriteLine("макс="+number2);
}
else
{
    Console.WriteLine("мин="+number2);
}
 