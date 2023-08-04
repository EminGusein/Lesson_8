namespace MyLib;
public static class MyLibClass
{
    public static int Input(string text) // Конвертирует тип данных введенных с клавиатуры (string) в тип данных int (целые числа)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void FillArray(int[] array, int minValue = -9, int maxValue = 9) // Заполняет массив случайными числами
    {
        maxValue++;
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(minValue, maxValue);
        }

    }


    public static void PrintArray(int[] array) // Печатает массив
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    public static int AmountEvenNum(int[] array) // Определяет количество чётных чисел
    {
        int amount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) amount++;
        }
        return amount;
    }

    public static int AmountOddNum(int[] array) // Определяет количество НЕчётных чисел
    {
        int amount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) amount += 0;
            else amount++;
        }
        return amount;
    }

    public static void FillArray(double[] array, int minValue = -9, int maxValue = 9) // Заполняет массив случайными вещественными числами
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
        }

    }

    public static void PrintArray(double[] array) // Печатает массив вещественных чисел
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    public static void FillArray(int[,] matrix, int minValue = -9, int maxValue = 9)
    {
        maxValue++;
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue);
            }

        }
    }

    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }


    public static void FillArray(double[,] matrix, int minValue = -9, int maxValue = 9)
    {
        //maxValue++;
        Random random = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
            }

        }
    }

    public static void PrintArray(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static int MinValue(int[] array)
    {
        int min = array[0];
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
            }
        }
        return minIndex;
        //return min;
    }

}




