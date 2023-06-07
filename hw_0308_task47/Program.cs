﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CraeteArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // arr[i, j] = new Random().Next(-9, 9); не понял как ввести в NextDouble периодизацию чисел, чтобы включить отрицательные)
            arr[i, j] = Math.Round((new Random().NextDouble() * 10), 1);
        }
    }
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число M: ");
int row = InputNumber();
Console.Write("Введите число N: ");
int colums = InputNumber();

double[,] array = new double[row, colums];
CraeteArray(array);
PrintArray(array);