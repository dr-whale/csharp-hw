
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(0, 11);
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

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
void SortedRow (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int sort = j + 1; sort < array.GetLength(1); sort++)
            {
                if (array[i, j] < array[i, sort])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, sort];
                    array[i, sort] = temp;
                }
            }
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SortedRow(newArray);
Show2dArray(newArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

void ShowMinimal (int[,] array)
{
    int minimalRow = 0;
    int currentRow = 0;
    int result = 0;
    for (int j = 0; j < array.GetLength(1); j++) minimalRow += array[0, j];
    Console.WriteLine($"1 row sum: {minimalRow}");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            currentRow += array[i, j];
        }
        Console.WriteLine($"{i + 1} row sum: {currentRow}");
        if (currentRow < minimalRow)
        {
            result = i;
            minimalRow = currentRow;
        }
    }
    Console.Write($"Number of minimal row is {result + 1}");
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ShowMinimal(newArray);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MatrixMultiplicator(int[,] firstArr, int[,] secondArr)
{
    int[,] result = new int[firstArr.GetLength(0), secondArr.GetLength(1)];
    if(firstArr.GetLength(1) == secondArr.GetLength(0)) 
    {
        Console.WriteLine("Matrix approved");
        for(int i = 0; i < result.GetLength(0); i++)
        {
            for(int j = 0; j < result.GetLength(1); j++)
            {
                for(int k = 0; k < firstArr.GetLength(1); k++)
                    result[i,j] += firstArr[i,k] * secondArr[k,j];
            }
        }
    }
    else 
    {
        Console.WriteLine("Wake Up Neo...");
        Console.WriteLine("The Matrix Has You...");
    }
    return result;
} 

Console.WriteLine("Input rows&columns for first array:");
int[,] firstArray = CreateRandom2dArray();
Show2dArray(firstArray);
Console.WriteLine("Input rows&columns for second array:");
int[,] secondArray = CreateRandom2dArray();
Show2dArray(secondArray);
int[,] newArray = MatrixMultiplicator(firstArray, secondArray);
Show2dArray(newArray);
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Create3dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of layers: ");
    int layers = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[rows, columns, layers];
    if (rows * columns * layers <= 90)
    {
        int[] numbers = new int[90];
        for(int i = 0; i < 90; i++)
            numbers[i] = i + 10;
        int n = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                for(int k = 0; k < layers; k++)
                {
                    array[i, j, k] = numbers[n];
                    n++;
                }
            }
        }
    }
    return array;
}

void Show3dArray (int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Layer {i + 1}:");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] newArray = Create3dArray();
Show3dArray(newArray);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Совсем не хватило времени, извините =(
*/