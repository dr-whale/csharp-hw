// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows (M): ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns (N): ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min posible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return array;
}

void Show2dArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 2) + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min posible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumberPosition (int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1)) Console.WriteLine($"Number: {array[row - 1, column - 1]}");
    else Console.WriteLine("No position");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.Write("Input a row number: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column number: ");
int column = Convert.ToInt32(Console.ReadLine());
NumberPosition(newArray, row, column);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min posible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max posible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ArithmeticMean(int[,] array)
{
    double[] responce = new double[array.GetLength(1)];
    int rows = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double tempSum = 0;
        for (int i = 0; i < rows; i++) tempSum += array[i, j];
        responce[j] = tempSum / rows;
    }
    return responce;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
double[] result = ArithmeticMean(newArray);
for (int i = 0; i < result.Length; i++) Console.WriteLine($"Result for column {i + 1}: {result[i]}");
*/