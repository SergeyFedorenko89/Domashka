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