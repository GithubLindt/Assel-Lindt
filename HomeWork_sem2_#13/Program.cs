Console.Write("Введите любое число :");
int n = int.Parse(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (n / 1000 != 0)
    {
        n = n / 10;
    }
int result = n % 10;
Console.WriteLine(result);
}