﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

int m = 1;
int n = 15;

Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} -> {CountNaturalSum(m, n)}");

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}