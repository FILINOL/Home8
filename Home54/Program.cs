// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr = new int[3, 4];

void RandomArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SelerArray()
{

for (int i = 0; i < arr.GetLength(0); i++)
{

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = j + 1; k < arr.GetLength(1); k++)
        {
            if (arr[i, k] > arr[i, j])
            {
                int temp = arr[i, k];
                arr[i, k] = arr[i, j];
                arr[i, j] = temp;
            }
        }
    }
}
}

void PrintEndArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

RandomArray();
PrintArray();
Console.WriteLine();
SelerArray();
PrintEndArray();