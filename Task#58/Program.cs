Console.Clear();

Random rand = new Random();
int[,] matrix1 = new int[3, 4];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = rand.Next(1, 9);
    }
}

int[,] matrix2 = new int[4, 3];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = rand.Next(1, 9);
    }
}

Console.WriteLine("\nMatrix 1:");
Print(matrix1);
Console.WriteLine("\nMatrix 2:");
Print(matrix2);
Console.WriteLine("\nMatrix 3 = Matrix 1 * Matrix 2:");
int[,] multi = Multiplication(matrix1, matrix2);
Print(multi);


int[,] Multiplication(int[,] a, int[,] b)
{
    // if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}
void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}
