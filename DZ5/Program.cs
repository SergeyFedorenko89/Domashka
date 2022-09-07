/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве*/

/*int[] RandomArray (int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void EnkArray(int[] array)
{
    int current = 0;
    for(int i = 0; i < array.Length; i = i + 1)
    {
        Console.WriteLine(array[i] + " ");
        if (array[i] % 2 == 0) current = current +1;
    }
    Console.WriteLine ($"Четных чисел {current} ");
}
Console.WriteLine ("Введите размер массива ");
int Enk = Convert.ToInt32(Console.ReadLine());
EnkArray (RandomArray (Enk));*/


/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях*/

/*int[] RandomArray (int size, int min, int max)
{
    int[] newArray = new int [size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max);
    }
    return newArray;
}
void EnkArray(int[] array)
{
    for(int i = 0; i < array.Length; i = i + 1)
    {
        Console.WriteLine(array[i] + " ");
    }
    Console.WriteLine();
}
int Chisla(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i = i + 1 )
    {
        if(i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}
Console.WriteLine ("Введите размер массива ");
int enk = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[] Array = RandomArray (enk, min, max);
EnkArray (Array);
Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях {Chisla(Array)}");*/

