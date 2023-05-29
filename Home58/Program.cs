// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6
int[,] arr = new int[2, 2];
int[,] array = new int[2, 2];
int[,] ResultArray = new int[2, 2];

void RandomArr()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0,10);
        }
    }
}
void PrintArr()
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

void RandomArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SumResultArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            ResultArray[i, j] = arr[i, j] * array[i, j];
        }
        
    }
}
void PrintEndArray()
{
    for (int i = 0; i < 2; i++)
    {
            for (int j = 0; j < 2; j++) {
                Console.Write(ResultArray[i, j] + " ");
            }
            Console.WriteLine("");
    }
}
RandomArr();
PrintArr();
Console.WriteLine();
RandomArray();
PrintArray();
Console.WriteLine("Результирующая матрица:");
SumResultArray();
PrintEndArray();

