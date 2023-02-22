Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());

int a1 = N / 10000;
int a2 = N / 1000 % 10;
int a4 = N / 10 % 10;
int a5 = N % 10;

if (a1 == a5 && a2 == a4)
{
    Console.WriteLine("-> yes");
}
else
{
    Console.WriteLine("-> no");
}