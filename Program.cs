/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A > B)
{
   Console.Write($"Число A: больше числа B: ");
}
else
{
   Console.Write($"Число B: больше числа A: ");
}


задача 2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введите три числа");
Console.Write("Число первое: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число второе: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число третье: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.Write($"Максимальное число {max} ");


задача 3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
{
    Console.Write($"Число четное  {number} ");
}
else
{
    Console.Write($"Число не четное  {number} ");
}*/


