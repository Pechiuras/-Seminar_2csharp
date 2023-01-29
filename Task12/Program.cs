//task 12 (Кратность чисел и вывод остатка от деления)
Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n % m == 1)
 {
    Console.Write($"Число не кратно, остаток {n % m}");
 }
else
{
      Console.Write("Число кратно");  
}

