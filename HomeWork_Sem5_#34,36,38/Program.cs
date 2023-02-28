// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] startArray = GetArray(5, 100, 1000);
Console.WriteLine(string.Join(", ", startArray));
Console.WriteLine($"количество четных чисел в отрезке от 100 до 1000 = {GetCountElements(startArray, 100, 1000)}");

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetCountElements(int[] array, int leftRange, int rightRange)
{
    int count = 0;
    foreach(int item in array)
    {
        if (item % 2 == 0) count++;
        // if (item <= leftRange && item >= rightRange) count++;
    }
    return count;
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] startArray = GetArray(7, -100, 100);
Console.WriteLine(string.Join(", ", startArray));

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int Sum = 0;
int i = 1;
int size = startArray.Length;

for (i = 1; i < startArray.Length; i += 2)
{
    Sum = Sum + startArray[i];
}

Console.WriteLine(Sum);

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [] array = new double[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(-100, 100);
}
Console.WriteLine(string.Join(", ", array));

// int min = 0;
// int max = 0;
double min = array[0];
double max = array[0];

for (int i = 1; i < n; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];
}

Console.WriteLine($"Минимальный элемент: {min}. Максимальный элемент: {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");
