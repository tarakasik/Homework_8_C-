int[,,] matrix = new int[2, 2, 2];
int count = 0;
ThreeDimensionalMatrix(matrix);

void ThreeDimensionalMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        count++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            count++;
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                count++;
                matrix[i, k, j] = count;
                System.Console.Write($"{matrix[i, k, j]} ({i},{k},{j})  \t");
            }
            Console.WriteLine();
        }
    }

}






