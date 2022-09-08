/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь*/

int enk(int num)
{
    int plus = 0;
    for(int i = 0; i < num; i = i + 1)
    {
      Console.WriteLine($"Введите число {i + 1}: ");
      int number = Convert.ToInt32(Console.ReadLine());
      if(number > 0)
      plus = plus + 1;
    }
    return plus;
}
Console.WriteLine("Введите количество чисел ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Положительных чисел {enk(num)} ");
