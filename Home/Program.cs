using MyLib;

// Урок 8. Двумерные массивы. Продолжение

void Task54()
{
    // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
    // элементы каждой строки двумерного массива.

    int rows = 4;
    int columns = 5;

    int[,] matrix = new int[rows, columns];

    MyLibClass.FillArray(matrix);
    MyLibClass.PrintArray(matrix);
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, max]) max = k;
            }
            (matrix[i, j], matrix[i, max]) = (matrix[i, max], matrix[i, j]);
        }
    }
    MyLibClass.PrintArray(matrix);





}

void Task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
    // с наименьшей суммой элементов.

    int rows = 5;
    int columns = 5;

    int[,] matrix = new int[rows, columns];
    int[] numbers = new int[rows];

    MyLibClass.FillArray(matrix);
    MyLibClass.PrintArray(matrix);
    Console.WriteLine();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        numbers[i] = sum;
    }
    // MyLibClass.PrintArray(numbers);
    Console.WriteLine($"Строка с наименьшей суммой элементов: {MyLibClass.MinValue(numbers) + 1}");

}

void Task58()
{
    // Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

    int rows = 4;
    int columns = rows;

    int[,] matrix = new int[rows, columns];

    MyLibClass.PrintArray(matrix);
    Console.WriteLine();

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= rows * columns)
    {
        matrix[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < columns - 1) j++;
        else if (i < j && i + j >= rows - 1) i++;
        else if (i >= j && i + j > columns - 1) j--;
        else i--;
    }

    MyLibClass.PrintArray(matrix);

}


Console.Clear();
Task58();
