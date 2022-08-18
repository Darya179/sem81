//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк массива A: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива A: ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Sort(int[,] sArray, int m, int n)
{
    int temp = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n - 1; j++)
        {
            for (int t = 0; t < n - j - 1; t++)
            {
                if (sArray[i,t] < sArray[i,t + 1])
                {
                    temp = sArray[i,t];
                    sArray[i,t] = sArray[i, t+1];
                    sArray[i, t+1] = temp;
                    
                
                 }
            }
        }
    }
}

int[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine(" ");
Sort(array, rows,columns);
PrintArray(array);