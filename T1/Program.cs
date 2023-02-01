using static System.Console;
Clear();


Write("Введите: размер матрицы, диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);


int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);


printMatrixArray(array);
WriteLine();
Reverse(array);
WriteLine();
printMatrixArray(array);
WriteLine();


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}


void printMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5}");
        }
        WriteLine();
    }

}

void Reverse(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(1) - 1; z++)
            {
                if (inArray[i, z] < inArray[i, z + 1])
                {
                    int temp = inArray[i, z + 1];
                    inArray[i, z + 1] = inArray[i, z];
                    inArray[i, z] = temp;
                }
            }
        }
    }
}
