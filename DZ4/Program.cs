/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B*/

/*int AiB (int number1, int number2)
{
    int current = 1;
    for (int i = 0; i < number2; i = i + 1 )
    {
        current = current * number1;
    }
    return current;
}
Console.WriteLine ("Введите первое число ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AiB (A , B));*/


/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе*/

/*int summa (int number)
{
    int sum = 0;
    int ber =0;
    while ( number > 0)
    {
        ber = number % 10;
        number = number / 10;
        sum = sum + ber;
    }
    return sum;
}
Console.WriteLine ("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (summa (num));*/


/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран*/

/*int[] EnkArray()
{
    Console.WriteLine("Введите ваш массив ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i + 1} :");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void PokazArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();    
}
PokazArray(EnkArray());*/