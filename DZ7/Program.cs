/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.*/

/*double[,] EnkRandomArray(int row, int col, int minValue, int maxValue)
{
    double[,] array = new double[row, col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
    {
        array[i,j] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(minValue, maxValue);   
    }
    }
    return array;
}
void Show2Array(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int newrow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int newcol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально число: ");
int newminValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально число: ");
int newmaxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] Array = EnkRandomArray(newrow, newcol, newminValue, newmaxValue);
Show2Array(Array);*/


/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет*/

/*int[,] EnkRandomArray(int row, int col, int minValue, int maxValue)
{
    int[,] newArray = new int[row, col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);   
        }
    }
    return newArray;
}
void NewShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
void Enk(int[,] array, int newrow, int newcol)
{
    if((newrow <= array.GetLength(0)) && (newcol <= array.GetLength(1)))
    Console.WriteLine($"Элемент с этим индексом равен: {array[newrow - 1, newcol - 1]}");
    else Console.WriteLine("Нет такого");
}
Console.Write("Введите количество строк : ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально число: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = EnkRandomArray(row, col, min, max);
NewShowArray(array);
Console.Write("Номер строки: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Enk(array, num1, num2);*/