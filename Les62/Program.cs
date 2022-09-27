﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

void PrintArrya(int[,] arg)  
{
    for (int i = 0; i < arg.GetLength(0); i++) 
    {
        for (int j = 0; j < arg.GetLength(1); j++)  
        {
            Console.Write($" {arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrya(int[,] arg)
{
    int[] mas = new int[arg.GetLength(0) * arg.GetLength(1)];
    int cout = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
     

        for (int j = 0; j < arg.GetLength(1); j++)
        {

            arg[i, j] = mas[cout];
            cout++;
            for (int k = 0; k < mas.Length; k++)
            {

                mas[cout] = k + 1;
                break;

            }

        }
    }
}

Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArrya(arr);
PrintArrya(arr);
Console.WriteLine();
Console.WriteLine();