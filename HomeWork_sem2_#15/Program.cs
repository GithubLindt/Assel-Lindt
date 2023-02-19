Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());

if (a <= 7)
{
    if (a == 6 || a == 7)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
else
{
    Console.WriteLine("Число не входит в заданный диапазон");
}