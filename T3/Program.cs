using static System.Console;
Clear();


Write("Введите: размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);


int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);



printMatrixArray(array);
WriteLine();
MinimElements(array);
WriteLine();



void MinimElements(int[,] InArray)
{
    int MinRow = 0;

     int MinSRow = 0;

      int SumRow = 0;

    for (int i = 0; i < InArray.GetLength(1); i++)
    {
        MinRow += InArray[0, i];
    }
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++) SumRow += InArray[i, j];
        {
            if (SumRow < MinRow)
            {
                MinRow = SumRow;
                MinSRow = i;
            }
            SumRow = 0;
        }
    }
    Write($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {MinSRow + 1} строка");
}



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