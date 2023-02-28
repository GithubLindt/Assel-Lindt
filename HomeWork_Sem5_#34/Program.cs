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

