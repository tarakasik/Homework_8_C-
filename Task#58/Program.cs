Console.Clear();

Random rand = new Random();

int[,] firstMatrix = new int[2, 2];
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        firstMatrix[i, j] = rand.Next(1, 9);
        Console.Write($"{firstMatrix[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Second array: ");
int[,] secondMatrix = new int[3, 4];
for (int i = 0; i < secondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        secondMatrix[i, j] = rand.Next(1, 9);
        Console.Write($"{secondMatrix[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Multiplication array: ");
int[,] thirdMatrix = new int[2,2];
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
            thirdMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
        Console.Write($"{thirdMatrix[i, j]}\t");
    }
    Console.WriteLine();
}