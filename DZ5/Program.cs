/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве*/

int[] RandomArray (int size)
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
EnkArray (RandomArray (Enk));

