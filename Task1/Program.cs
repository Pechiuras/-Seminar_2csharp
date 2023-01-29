// Выбор случайного числа из отрезка и вывод наибольшей цифры числа.
Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine($"Случайное число: {n}"); 
int n1 = n / 10;
int n2 = n % 10;

if (n1 > n2)
      Console.WriteLine(n1);
else
      Console.WriteLine(n2);     

 





