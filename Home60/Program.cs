int[,,] arr = new int[2, 2, 2];

void RandomArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(0,10);
            }
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write("{0}({1},{2},{3}) ", arr[i, j, k], i, j, k);
            }
            Console.WriteLine();
        }
    }
}

RandomArray();
PrintArray();
