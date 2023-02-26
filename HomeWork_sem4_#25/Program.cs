Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

int number = (int)Math.Pow(a,b);
Console.WriteLine($"Возведение числа 1 в степень числа 2 = {number}");