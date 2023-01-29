Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 161 == 0)
 {
    Console.Write($"Число кратно");
 }
else
{
      Console.Write("Число не кратно");  
}
