/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив*/

int[,] NewRandomArray(int row, int col, int min, int max)
{
     int[,] array = new int[row, col];
     for(int i = 0; i < row; i++)
         for(int j = 0; j < col; j++)
             array[i, j] = new Random().Next(min, max + 1);
     return array;
}
void Show2Array(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
         for(int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write(array[i, j]);
             Console.Write(' ');
         }
         Console.WriteLine();
     }
}

void Enk(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
         for(int j = 0; j < array.GetLength(1) - 1; j++)
         {
             for(int k = j + 1; k < array.GetLength(1); k++)
             {
                 if(array[i, j] < array[i, k])
                 {
                     int temp = array[i, j];
                     array[i, j] = array[i, k];
                     array[i, k] = temp;
                 }
             }
         }
}
Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально число: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = NewRandomArray(row, col, min, max);
Show2Array(array);
Console.WriteLine();
Enk(array);
Show2Array(array);