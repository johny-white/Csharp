Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1=number;
int number2=1;
while (number1>=10)
{
    number1/=10;
    number2*=10;
}
while (number2>1)
{
   Console.Write(number/number2%10 +", ");
   number2/=10;
 }
Console.WriteLine(number%10);