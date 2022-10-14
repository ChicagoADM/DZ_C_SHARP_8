void Exit()
{
    Console.WriteLine();
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach56()
{
    //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Console.Clear();
    int rows = 4;
    int colums = 5;
    int[,] numbers = new int[rows, colums];
    int[] sum_numbers = new int[numbers.GetLength(0)];

    FillArray(numbers);
    PrintArray(numbers);
    NumSum(numbers, sum_numbers);
    MinArray(sum_numbers);
}

void FillArray(int[,] numbers)
{
    Random random = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }

}

void PrintArray(int[,] numbers)
{
    Console.WriteLine("Прямоугольный двумерный массив: ");
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumSum(int[,] numbers, int[] sum_numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int num = 0;
        for (int j = 0; j < colums; j++)
        {
            num += numbers[i, j];
            sum_numbers[i] = num;
        }
        Console.WriteLine($"Сумма чисел строки {i + 1} ровна: {sum_numbers[i]}");
    }
    Console.WriteLine();
}
void MinArray(int[] sum_numbers)
{
    int min = sum_numbers[0];
    int index = 0;
    for (int i = 0; i < sum_numbers.Length; i++)
    {
        if (min >= sum_numbers[i])
        {
            min = sum_numbers[i];
            index = i + 1;
        }
    }
    Console.WriteLine($"У строки {index} наименьшая сумма элементов");
    Console.WriteLine();
}
Zadach56();
Exit();