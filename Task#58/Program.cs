Console.Clear();
int[,] firstMatrix = new int[2, 3];
int[,] secondMatrix = new int[3, 4];
Random rand = new Random();
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();
FillArray2(secondMatrix);
PrintArray2(secondMatrix);



void FillArray(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            firstMatrix[i, j] = rand.Next(1, 9);
        }
    }
}
void PrintArray(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            Console.Write("{0}\t", firstMatrix[i, j]);
        }
        Console.WriteLine();
    }
}
void FillArray2(int[,] secondMatrix)
{
    for (int k = 0; k < secondMatrix.GetLength(0); k++)
    {
        for (int l = 0; l < secondMatrix.GetLength(1); l++)
        {
            secondMatrix[k, l] = rand.Next(1, 9);
        }
    }
}

void PrintArray2(int[,] secondMatrix)
{

    for (int k = 0; k < secondMatrix.GetLength(0); k++)
    {
        for (int l = 0; l < secondMatrix.GetLength(1); l++)
        {
            Console.Write("{0}\t", secondMatrix[k, l]);// "{0}\n", secondMatrix[i, j]);
        }
        Console.WriteLine();

    }
}

//                 {
//                     Console.Write("{0}\t", firstMatrix[i, j], "{0}\n", secondMatrix[i, j]);
//                 }
//             }
//         }
//     }
// }