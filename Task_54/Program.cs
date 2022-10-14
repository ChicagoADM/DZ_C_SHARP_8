void Exit()
{
    Console.WriteLine();
    Console.Write("Нажмите любою клавишу... ");
    Console.ReadKey();
}
void Zadach54()
{
    //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    Console.Clear();
    int[,] matrix = new int[5, 5];
    int[,] matrix_sort = new int[matrix.GetLength(0), matrix.GetLength(1)];

    FillArray(matrix, matrix_sort);
    SortArray(matrix, matrix_sort);
    PrintArray(matrix, matrix_sort);
    PrintArray2(matrix, matrix_sort);
}
void FillArray(int[,] matrix, int[,] matrix_sort)
{
    Random random = new Random();
    int str = matrix.GetLength(0);
    int colums = matrix.GetLength(1);

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            matrix[i, j] = random.Next(1, 100);
            matrix_sort[i, j] = matrix[i, j];
        }
    }
}
void SortArray(int[,] matrix, int[,] sorting_number)
{
    int str = matrix.GetLength(0);
    int colums = matrix.GetLength(1);
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < colums; k++)
            {
                if (sorting_number[i, j] > sorting_number[i, k])
                {
                    int temp = sorting_number[i, j];
                    sorting_number[i, j] = sorting_number[i, k];
                    sorting_number[i, k] = temp;
                }
            }
        }
    }
}
void PrintArray(int[,] matrix, int[,] matrix_sort)
{

    Console.WriteLine("Двумерный массив: ");
    Console.WriteLine();
    int str = matrix.GetLength(0);
    int colu = matrix.GetLength(1);

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < colu; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

void PrintArray2(int[,] matrix, int[,] matrix_sort)
{
    Console.WriteLine("Упорядоченный по убыванию двумерный массив: ");
    Console.WriteLine();
    int str = matrix.GetLength(0);
    int colu = matrix.GetLength(1);

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < colu; j++)
        {
            Console.Write($"{matrix_sort[i, j]}\t");
        }
        Console.WriteLine();
    }

}

Zadach54();
Exit();