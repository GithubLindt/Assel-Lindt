Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N;

if (N < 0)
{
    i = N;//-10
    m = -N;//10
    N = -1;//-1
}
int[] result = new int[m];

int j = 0;


for (j = 0; i <= N; i++)
{
    result[j] = i * i * i;
    j++;
}
for (j = 0; j < m; j++)
{
    Console.WriteLine($"{result[j]} ");
}