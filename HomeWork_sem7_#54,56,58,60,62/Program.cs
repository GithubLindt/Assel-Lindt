// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// using System;
// using static System.Console;

// Clear();

// Write("vvedite kolichestvo strok: ");
// int rows = int.Parse(ReadLine());
// Write("vvedite kolichestvo stolbcov: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray (rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Write(input);
//   int output = Convert.ToInt32(ReadLine());
//   return output;
// }
// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Write(array[i, j] + " ");
//     }
//     WriteLine();
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// using System;
// using static System.Console;

// Clear();

// Write("vvedite kolichestvo strok: ");
// int rows = int.Parse(ReadLine());
// Write("vvedite kolichestvo stolbcov: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray (rows, columns, 0, 10);
// PrintArray(array);
// WriteLine();

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// int minSum = 0;
// int Sum = SumElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int S = SumElements(array, i);
//   if (Sum > S)
//   {
//     Sum = S;
//     minSum = i;
//   }
// }

// WriteLine($"{minSum+1} - строкa с наименьшей суммой ({Sum}) элементов ");


// int SumElements(int[,] array, int i)
// {
//   int Sum = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     Sum += array[i,j];
//   }
//   return Sum;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(0, 10);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Write(array[i,j] + " ");
//     }
//     WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// using System;
// using static System.Console;

// Clear();

// Write("vvedite kolichestvo strok: ");
// int m = int.Parse(ReadLine());
// Write("vvedite kolichestvo stolbcov: ");
// int n = int.Parse(ReadLine());

// int[,] array1 = GetArray (m, n, 0, 2);
// PrintArray(array1);
// WriteLine();
// int[,] array2 = GetArray (m, n, 0, 2);
// PrintArray(array2);
// WriteLine();

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Write($"{inArray[i, j]} ");
//         }
//         WriteLine();
//     }
// }

// int[,] newArray = new int[m,n];

// MultiplyMatrix(array1, array2, newArray);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(newArray);

// void MultiplyMatrix(int[,] array1, int[,] array2, int[,] newArray)
// {
//   for (int i = 0; i < newArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < newArray.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < array1.GetLength(1); k++)
//       {
//         sum += array1[i,k] * array2[k,j];
//       }
//       newArray[i,j] = sum;
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Write(array[i,j] + " ");
//     }
//     WriteLine();
//   }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// using System;
// using static System.Console;

// Clear();

// Write("vvedite a: ");
// int a = int.Parse(ReadLine());
// Write("vvedite b: ");
// int b = int.Parse(ReadLine());
// Write("vvedite c: ");
// int c = int.Parse(ReadLine());

// int[,,] array = GetArray (a, b, c, 0, 10);
// PrintArray(array);
// WriteLine();
// CreateArray(array);
// WriteArray(array);

// int[,,] GetArray(int m, int n, int p, int min, int max)
// {
//     int[,,] result = new int[m, n, p];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             for (int k = 0; k < p; k++)
//             {
//                 result[i, j, k] = new Random().Next(min, max + 1);
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < inArray.GetLength(2); k++)
//             {
//                 Write($"{inArray[i, j, k]} ");
//             }
//         }
//         WriteLine(  );
//     }
// }

// void WriteArray (int[,,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Write($"A({i}) B({j}) ");
//       for (int k = 0; k < array.GetLength(2); k++)
//       {
//         Write( $"C({k})={array[i,j,k]}; ");
//       }
//       WriteLine();
//     }
//     WriteLine();
//   }
// }

// void CreateArray(int[,,] array)
// {
//   int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int a = 0; a < array.GetLength(0); a++)
//   {
//     for (int b = 0; b < array.GetLength(1); b++)
//     {
//       for (int c = 0; c < array.GetLength(2); c++)
//       {
//         array[a, b, c] = temp[count];
//         count++;
//       }
//     }
//   }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

// using System;
// using static System.Console;

// int m = 4;
// int[,] sqareMatrix = new int[m, m];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Write($" {array[i,j]} ");

//       else Write($"{array[i,j]} ");
//     }
//     WriteLine();
//   }
// }

// **Задача 61: Показать треугольник Паскаля. 
// *Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;

Clear();

Write("vvedite n: ");
int n = int.Parse(ReadLine());

double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

FillPascalTriangle(pascalTriangle);

TransformationPascalTriangle(pascalTriangle);

WriteLine();
WriteArray(pascalTriangle);

void TransformationPascalTriangle(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}


void FillPascalTriangle(double[,] pascalTriangle)
{
  for (int k = 0; k < pascalTriangle.GetLength(0); k++)
  {
    pascalTriangle[k, 0] = 1;
  }
  for (int i = 1; i < pascalTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
    }
  }
}

void WriteArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Write($"{array[i, j]} ");
      }
      else Write("  ");
    }
    WriteLine();
  }
}
