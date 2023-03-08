// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// using System;
// using static System.Console;

// Clear();

// WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(ReadLine());
// WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(ReadLine());
// double[,] array = new double[m, n];
// Random rnd = new Random();
// void PrintArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { Write($"{matr[i, j]} ");}
//  WriteLine();}}

// void FillArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { matr[i,j] = Convert.ToDouble(rnd.Next(-10, 10)/10.0);}}}
// FillArray(array);
// WriteLine();
// PrintArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// using System;
// using static System.Console;

// Clear();

// WriteLine("введите номер строки");
// int m = Convert.ToInt32(ReadLine());
// WriteLine("введите номер столбца");
// int n = Convert.ToInt32(ReadLine());
// int [,] array = new int [10,10];
// FillArrayRandomNumbers(array);

// if (m > array.GetLength(0) || n > array.GetLength(1))
// {
//     WriteLine("такого элемента нет");
// }
// else
// {
//     WriteLine($"значение элемента {m} строки и {n} столбца равно {array[m-1,n-1]}");
// }

// PrintArray(array);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Write(array[i,j] + " ");
//         }   
//         Write("]");
//         WriteLine(""); 
//     }
// }

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// using System;
// using static System.Console;

// Clear();

// Write("vvedite kolichestvo strok: ");
// int rows = int.Parse(ReadLine());

// Write("vvedite kolichestvo stolbcov: ");
// int columns = int.Parse(ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m,n];
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
//     WriteLine();
// }

// double average = 0;

// for (int j = 0; j < array.GetLength(1); j++)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         average = (average + array[i, j]);
//     }
//     average = average / rows;
//     Write(average + "; ");
// }
// WriteLine();
