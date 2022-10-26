// Задача 47 Задайте двумерный массив размером m на n, заполненный слуучайными вещетвенными числами.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] realMassiv = new double[rows, columns];

// void FillRandom(double[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             realMassiv[i, j] = new Random().Next(5, 10);
//         }
//     }
// }

// void PrintArray(double[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             Console.Write($"{Math.Round(realMassiv[i, j] / 1.5, 2)} ");
//         }
//         Console.WriteLine();
//     }
// }

// FillRandom(realMassiv);
// PrintArray(realMassiv);

// Задача 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желаемое значение строки: ");
int rows_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желаемок значание столбца: ");
int columns_1 = Convert.ToInt32(Console.ReadLine());

int[,] massiv = new int[rows, columns];

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i, j] = new Random().Next(5, 10);
    }

}

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        if (i == rows_1 && j == columns_1)
        {
            Console.WriteLine($"Значение элемента на позиции {(i)},{(j)} = {massiv[i, j]}");
        }
    }
}



// Задача 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Введите количетсво строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количетсво столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// void FillArray(int[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-5, 5);
//         }
//     }
// }

// void PrintArray(int[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void Average(int[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         double aver = 0;
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             aver = aver + array[i, j];
//             Console.WriteLine($"Среднее арифметическое элементов столбца {j + 1} = {Math.Round((aver / rows), 2)}");
//         }
//     }
// }

// FillArray(array);
// PrintArray(array);
// Average(array);