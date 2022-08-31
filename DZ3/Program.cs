/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.*/

/*void Pali (int number)
{
    int revers = 0;
    int num = number;
    int ber = 0;
    while (number > 0)
     {
        ber = number % 10;
        number = number / 10;
        revers = revers * 10 + ber;
     }
    if (num == revers) 
    Console.WriteLine ($"Это число палиндром");
    else
    Console.WriteLine($"Это число не палиндром");
}
Console.WriteLine ("Введите число ");
int drom = Convert.ToInt32(Console.ReadLine());
Pali (drom);*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/

/*double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2-z1) * (z2-z1));
}
Console.WriteLine("Введите координаты первых точек (x, y, z) : ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ВВедите координаты вторых точек (x, y, z) : ");
double xB = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());
double Dis = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"3D {Dis}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/

/*void Kubik (int number)
{
    int current = 1;
    while (current <= number)
     {
        Console.Write(current * current * current + " ");
        current++;
     }
}
Console.WriteLine("Введите число: ");
int Kub = Convert.ToInt32(Console.ReadLine());
Kubik(Kub);*/