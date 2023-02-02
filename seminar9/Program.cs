// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*

void ShowNums (int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNums (n - 1);
}
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ElementsSum(int m, int n, int sum)
{
    if (n < m)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    sum += m;
    if (m < n) return ElementsSum(m + 1, n, sum);
    return sum;
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Sum of elemets: " + ElementsSum(m, n, 0));
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunc(m - 1, 1);
    else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AkkermanFunc(m, n));
*/