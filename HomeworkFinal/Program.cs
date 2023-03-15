// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// using System;
// using static System.Console;

// Clear();

// Write("Введите положительное число: ");
// int N = int.Parse(ReadLine());

// int n = 1;
// if (N < n)
// {
//     WriteLine("Ввели не положительное число");
// }
// else
// {
//     WriteLine(NaturalNumber(N, n));
// }

// int NaturalNumber(int N, int n)
// {
//     if (N == n)
//         return N;
//     else
//         Write($"{NaturalNumber(N, n + 1)}, ");
//     return n;
// }

// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// using System;
// using static System.Console;

// Clear();

// Write("Введите число M: ");
// int M = int.Parse(ReadLine());

// Write("Введите число N, которое будет больше, чем M: ");
// int N = int.Parse(ReadLine());

// if (N < M)
// {
//     WriteLine("Число N должно быть больше, чем число M");
// }
// else
// {
//     WriteLine($"Сумма элементов от {M} до {N} = {CountNaturalSum(M, N)}");
// }

// int CountNaturalSum(int M, int N)
// {
//     if (M == N)
//         return N;
//     return N + CountNaturalSum(M, N - 1);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// using System;
// using static System.Console;

// Clear();

// Write("Введите положительное число M: ");
// int M = int.Parse(ReadLine());

// Write("Введите положительное число N: ");
// int N = int.Parse(ReadLine());

// if (M <= 0 || N <= 0)
// {
//     WriteLine("Ввели не положительное число");
// }
// else
// {
//     WriteLine($"A({M}, {N}) = {Akkerman(M, N)}");
// }

// int Akkerman(int M, int N)
// {
//     if (M == 0)
//         return N + 1;
//     if (M > 0 && N == 0)
//         return Akkerman(M - 1, 1);
//     else
//         return Akkerman(M - 1, Akkerman(M, N - 1));
// }